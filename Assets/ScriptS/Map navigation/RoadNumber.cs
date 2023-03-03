using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadNumber : MonoBehaviour
{
    private string roadNumber;

    public void NumberRoad(string nameRoad)
    {
        roadNumber = nameRoad;
        Main.Road = roadNumber;
    }
}
