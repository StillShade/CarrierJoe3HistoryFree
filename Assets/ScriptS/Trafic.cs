using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trafic : MonoBehaviour
{	
	WheelJoint2D[] wheelJoints;
	JointMotor2D frontWheel;
	JointMotor2D backWheel;
		
	GameObject prefCarClon;
		
	[Header("Auto")]
	public GameObject Bison200;
	
	
	private float fuel = 10f;
	public float carAcceleration;
	public float carSpeed;
	private float minSpeed = 1;	
	public float thrustCar;
	

	private float backSpeed;
	private float deacceleration;
	public float brakeForce;
	private float gravity = 9.8f;
	private float angleCar = 0f;


	private Vector3 startpos = new Vector3(30f, 0f, 0f);
	private Vector3 curpos;

	public int Gear;

	public AudioSource[] carSound;

	public bool turnUp;

	public float turnovers;

	public float speed;	

	public bool accelclickedIs = true;
	public bool brakeclickedIs = false;

	void Start()
	{
		prefCarClon = Instantiate(Bison200, startpos, Quaternion.identity) as GameObject;
		curpos = startpos;
		Gear4();
	}

	public void Acceler()
	{
		accelclickedIs = true;
	}

	public void Deacceler()
	{
		accelclickedIs = false;
	}


	public void Braker()
	{
		brakeclickedIs = true;		
	}

	public void DeBraker()
	{
		brakeclickedIs = false;		
	}

	///////////////////   G E A R   ///////////////////////////////////////////////////////////////////////////////////////////////	

	public void Gear4()
	{
		Gear = 4;
		carSpeed = 2200;
		carAcceleration = 800;
		thrustCar = 20;
	}

	public void vGarage()
	{
		prefCarClon.transform.rotation = Quaternion.identity;
		prefCarClon.transform.position = startpos;
	}
	public void EngineSpeedUp()
	{
		turnUp = true;
	}
	public void EngineSpeedDw()
	{
		turnUp = false;
	}

	//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	void FixedUpdate()
	{		
		carSound = prefCarClon.GetComponents<AudioSource>();
		backSpeed = -400;
		deacceleration = -200;
		brakeForce = -500;


		wheelJoints = prefCarClon.GetComponents<WheelJoint2D>();		
		backWheel = wheelJoints[1].motor;
		frontWheel = wheelJoints[0].motor;

		frontWheel.motorSpeed = backWheel.motorSpeed;		
		angleCar = prefCarClon.transform.localEulerAngles.z;
	
		if (Gear >= 1)
		{
			turnovers = ((speed - (-minSpeed / 20)) * 2500 + 500 * ((-carSpeed / 20) - speed)) / ((-carSpeed / 20) - (-minSpeed / 20));
		}		

		if (angleCar >= 180)
		{
			angleCar = angleCar - 360;
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
		if (turnovers > 2500)
			turnovers = 2500;
		if (turnovers < 500)
			turnovers = 500;
		
		//движение автомобиля		
		if (brakeclickedIs == false)
		{
			if (fuel > 0)
			{
				frontWheel.maxMotorTorque = 0;
				
				if (accelclickedIs == true)
				{
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (carAcceleration - gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, backSpeed);
				}
				else if (backWheel.motorSpeed < 0)
				{
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, 0);
				}
				else if (backWheel.motorSpeed > 0)
				{
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, 0, backSpeed);
				}
				else if (angleCar < 0)
				{
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, 0);
				}
				else
				{
					backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, 0, backSpeed);
				}
			}
			else if (backWheel.motorSpeed < 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, 0);
			}
			else if (backWheel.motorSpeed > 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, 0, backSpeed);
			}
			else if (angleCar < 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, carSpeed + gravity * Mathf.PI * (angleCar / 180) * thrustCar * 2, 0);
			}
			else
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - (-deacceleration - 2.5f * gravity * Mathf.PI * (angleCar / 180) * thrustCar) * Time.deltaTime, 0, backSpeed);
			}
		}
		else
		{					
			if (backWheel.motorSpeed > 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed - brakeForce * Time.deltaTime, 0, backSpeed);
			}
			else if (backWheel.motorSpeed < 0)
			{
				backWheel.motorSpeed = Mathf.Clamp(backWheel.motorSpeed + brakeForce * Time.deltaTime, carSpeed, 0);
			}
		}
		
		wheelJoints[1].motor = backWheel;
		wheelJoints[0].motor = frontWheel;		
		
		{
			carSound[0].pitch = Mathf.Clamp((turnovers / 1250), 0.7f, 2f);
			carSound[0].volume = Mathf.Clamp((turnovers / 2500), 0.2f, 1f);			
		}
	}
}
