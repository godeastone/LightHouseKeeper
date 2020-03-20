using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogamManager : MonoBehaviour
{
    public Boat boat;
    private int level;
    public static DogamManager dogam_instance;

    public Boat[] BoatList;
    

    private void Start()
    {
    }

    public void BoatClick()
    {
        level = boat.level;
        if(BoatList[level-1].is_detected == false)
        {
            BoatList[level-1].is_detected = true;
        }
        
    }


}
