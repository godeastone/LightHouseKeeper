using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    public DatabaseManager Data;
    public RadioManager Radio;

    public Animator Light;

    public bool turning = false;
    bool quest_off = false;
    bool quest_right = false;
    bool quest_left = false;



    public void PowerButton()
    {
        if (Data.Light_Power == true)
        {
            Light.SetBool("Power", false);
            Data.Light_Power = false;
        }
        else
        {
            Light.SetBool("Power", true);
            Data.Light_Power = true;
        }

        CheckQuest(0);// quest #1is "Turn off the light"
    }

    public void RightButton()
    {
        if (turning == false)
        {
            Data.Light_Angle = 1;
            turning = true;
            StartCoroutine("TurnRight");
        }
        else
        {
            //경고문 쓰는 자리
        }

        CheckQuest(1);// quest #1is "Trun right the light"
    }

    public void LeftButton()
    {
        if (turning == false)
        {
            Data.Light_Angle = -1;
            turning = true;
            StartCoroutine("TurnLeft");
        }
        else
        {
            //경고문 쓰는 자리
        }

        CheckQuest(2);// quest #1is "Trun left the light"
    }

    IEnumerator TurnRight()
    {
        Light.SetBool("Auto", false);
        Light.SetBool("Right", true);
        Light.SetBool("Left", false);

        yield return new WaitForSeconds(6.0f);

        Light.SetBool("Auto", true);
        Light.SetBool("Right", false);
        Light.SetBool("Left", false);
        turning = false;
        Data.Light_Angle = 0;
    }

    IEnumerator TurnLeft()
    {
        Light.SetBool("Auto", false);
        Light.SetBool("Right", false);
        Light.SetBool("Left", true);

        yield return new WaitForSeconds(6.0f);

        Light.SetBool("Auto", true);
        Light.SetBool("Right", false);
        Light.SetBool("Left", false);
        turning = false;
        Data.Light_Angle = 0;
    }

    public void CheckQuest(int num) // parameter로 퀘스트 종류 번호를 준다.
    {
        if(Data.quest_ing == true)
        {
            if(num == Radio.count)
            {
                Radio.listSentences[Radio.count].is_success = true;
            }
        }
    }


    // Update is called once per frame

}
