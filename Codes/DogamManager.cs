using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogamManager : MonoBehaviour
{
    private int level;
    public Boat[] BoatList;

    public static DogamManager dogam_instance;

    public Animator DogamOpenButton;
    public Animator Boat1;
    public Animator Boat2;
    public Animator Boat3;
    public Animator Boat4;
    public Animator Boat5;


    private void Start()
    {
        dogam_instance = this;
    }

    public void DogamOpen()
    {
        DogamOpenButton.SetBool("Appear", false);

        if(BoatList[0].is_detected == true)
        {
            Boat1.SetBool("Appear", true);
        }
        if (BoatList[1].is_detected == true)
        {
            Boat2.SetBool("Appear", true);
        }
        if (BoatList[2].is_detected == true)
        {
            Boat3.SetBool("Appear", true);
        }
        if (BoatList[3].is_detected == true)
        {
            Boat4.SetBool("Appear", true);
        }
        if (BoatList[4].is_detected == true)
        {
            Boat5.SetBool("Appear", true);
        }
    }



    


}
