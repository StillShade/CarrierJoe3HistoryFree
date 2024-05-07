using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.Universal;

using TMPro; // using text mesh for the clock display

using UnityEngine.Rendering; // used to access the volume component

public class DayNightScript : MonoBehaviour
{
    public Text timeDisplay; // Display Time
    public Text dayDisplay; // Display Day
    //public Volume ppv; // this is the post processing volume

    public Light2D lights;
    public GameObject lightSalon;
    public GameObject lightGarage;
    public GameObject lightAZS;
    public GameObject lightSklad;
    public GameObject lightStreet;

    public float tick; // Increasing the tick, increases second rate
    public float seconds;
    public int mins;
    public int hours;
    public int days;

    public bool activateLights; // checks if lights are on
    //public GameObject[] lights; // all the lights we want on when its dark
    public SpriteRenderer[] stars; // star sprites 
    // Start is called before the first frame update
    void Start()
    {
        lights = gameObject.GetComponent<Light2D>();
        mins = Main.Mins;
        hours = Main.Hours;
        days = Main.Days;
        if (hours >= 22)
        {
            lights.intensity = 0.2f;
            OnLights();
        }
        if (hours <= 6)
        {
            lights.intensity = 0.2f;
            OnLights();
        }
        if (hours >= 7 && hours <= 21)
        {
            lights.intensity = 1;
            OffLights();
        }
    }

    // Update is called once per frame
    void FixedUpdate() // we used fixed update, since update is frame dependant. 
    {
        CalcTime();
        DisplayTime();
        Main.Mins = mins;
        Main.Hours = hours;
        Main.Days = days;
    }

    public void CalcTime() // Used to calculate sec, min and hours
    {
        seconds += Time.fixedDeltaTime * tick; // multiply time between fixed update by tick

        if (seconds >= 60) // 60 sec = 1 min
        {
            seconds = 0;
            mins += 1;
        }

        if (mins >= 60) //60 min = 1 hr
        {
            mins = 0;
            hours += 1;
        }

        if (hours >= 24) //24 hr = 1 day
        {
            hours = 0;
            days += 1;
        }
        ControlPPV(); // changes post processing volume after calculation
    }

    public void ControlPPV() // used to adjust the post processing slider.
    {
        //ppv.weight = 0;
        if (hours >= 21 && hours < 22 && lights.intensity >= 0.2f) // dusk at 21:00 / 9pm    -   until 22:00 / 10pm
        {
            lights.intensity = 1 - (float)mins / 60; // since dusk is 1 hr, we just divide the mins by 60 which will slowly increase from 0 - 1 
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].color = new Color(stars[i].color.r, stars[i].color.g, stars[i].color.b, 1 - (float)mins / 60); // change the alpha value of the stars so they become visible
            }
            if (lights.intensity < 0.2f)
            {
                lights.intensity = 0.2f;
            }
        }

        if (hours >= 6 && hours < 7) // Dawn at 6:00 / 6am    -   until 7:00 / 7am
        {
            lights.intensity = 0.2f + (float)mins / 60; // we minus 1 because we want it to go from 1 - 0
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].color = new Color(stars[i].color.r, stars[i].color.g, stars[i].color.b, (float)mins / 60); // make stars invisible
            }
            if (lights.intensity > 1f)
            {
                lights.intensity = 1f;
            }
        }

        if (hours == 21 && mins >= 20)
        {
            OnLights();
        }
        if (hours == 6 && mins >= 20)
        {
            OffLights();
        }
    }

    public void OnLights()
    {
        lightSalon.SetActive(true);
        lightGarage.SetActive(true);
        lightAZS.SetActive(true);
        lightSklad.SetActive(true);
    }

    public void OffLights()
    {
        lightSalon.SetActive(false);
        lightGarage.SetActive(false);
        lightAZS.SetActive(false);
        lightSklad.SetActive(false);
    }

    public void OnLightStreet()
    {
        if(hours >= 22)
            lightStreet.SetActive(true);
        if (hours <= 6)
            lightStreet.SetActive(true);
        else
            lightStreet.SetActive(false);
    }

    public void OffLightStreet()
    {
        lightStreet.SetActive(false);
    }

    public void DisplayTime() // Shows time and day in ui
    {

        timeDisplay.text = string.Format("{0:00}:{1:00}", hours, mins); // The formatting ensures that there will always be 0's in empty spaces
        dayDisplay.text = "Day: " + days; // display day counter
    }
}