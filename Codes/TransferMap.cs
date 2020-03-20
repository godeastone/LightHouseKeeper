using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferMap : MonoBehaviour
{
    public DatabaseManager Data;
    public RadioManager Radio;

    public Transform target1;
    public Transform target2;
    public Transform target3;
    public CameraManager theCamera;
    public Animator button1;
    public Animator button2;
    public Animator telescope_button;
    public Animator dogam_button;
    public Animator dept_button;
    public Animator facility_button;
    public Animator control_button;
    public Animator radio_button;
    public Animator radio_text;
    public Animator radio_window;
    public Animator TelescopeCloseButton;
    public Animator SpawnManager1;



    void Start()
    {
        theCamera = FindObjectOfType<CameraManager>();
    }

    public void MovePage1()
    {
        theCamera.transform.position = new Vector3(target1.transform.position.x, target1.transform.position.y, theCamera.transform.position.z);
        button1.SetBool("Appear", false);
        button2.SetBool("Appear", true);
        dogam_button.SetBool("Appear", true);
        control_button.SetBool("Appear", true);
        dept_button.SetBool("Appear", false);
        facility_button.SetBool("Appear", false);
        radio_button.SetBool("Appear", false);
        radio_text.SetBool("Appear", false);
        telescope_button.SetBool("Appear", true);
        TelescopeCloseButton.SetBool("Appear", false);
        SpawnManager1.SetBool("Appear", false);



        if (Data.quest_ing == true)// When performing a quest
        {
            radio_window.SetBool("Appear", false);
        }
    }

    public void MovePage2()
    {
        theCamera.transform.position = new Vector3(target2.transform.position.x, target2.transform.position.y, theCamera.transform.position.z);
        button2.SetBool("Appear", false);
        button1.SetBool("Appear", true);
        dogam_button.SetBool("Appear", false);
        control_button.SetBool("Appear", false);
        dept_button.SetBool("Appear", true);
        facility_button.SetBool("Appear", true);
        radio_button.SetBool("Appear", true);
        radio_text.SetBool("Appear", true);
        telescope_button.SetBool("Appear", false);
        

        if (Data.quest_ing == true)// When performing a quest
        {
            if (Radio.count == -1)//if the quest was successful
            {
                radio_window.SetBool("Appear", false);
            }
            else
            {
                radio_window.SetBool("Appear", true);
            }
        }
    }

    public void MovePage3()
    {
        theCamera.transform.position = new Vector3(target3.transform.position.x, target3.transform.position.y, theCamera.transform.position.z);
        button2.SetBool("Appear", false);
        dogam_button.SetBool("Appear", false);
        control_button.SetBool("Appear", false);
        telescope_button.SetBool("Appear", false);
        TelescopeCloseButton.SetBool("Appear", true);
        SpawnManager1.SetBool("Appear", true);
    }
}
