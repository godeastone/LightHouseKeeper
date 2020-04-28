using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public DatabaseManager Data;
    public DeptManager Dept;
    public TransferMap Map;

    public Animator salary_page;
    public Animator dogam_page;
    public Animator control_page;
    public Animator dept_page;
    public Animator facility_page;
    public Animator salary_button;
    public Animator salary_text;
    public Animator splash1;
    public Animator mainimg;
    public Animator mainimg2;
    public Text text_sal;
    
    void Start()
    {
        mainimg.SetBool("Appear", true);
        mainimg2.SetBool("Appear", true);
        splash1.SetBool("Appear1", false);
        splash1.SetBool("Appear2", false);
    }


    void Update()
    {
        TimeFlow();

        if (Data.Ispause == true)
        {
           Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            text_sal.text = "";
            salary_page.SetBool("Appear", false);
            salary_button.SetBool("Appear", false);
            salary_text.SetBool("Appear", false);
        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    

    int Count_ship()
    {
        Data.random_n = Random.Range(1, 30 );
        return Data.random_n;
    }

    
    // /////////////////////////////버튼 함수///////////////////////////////////////////////////////////
   
    public void BtnClick()
    {
        Data.Ispause = false;
    }

    public void titleBtnClick()
    {
        mainimg.SetBool("Appear", false);
        mainimg2.SetBool("Appear", false);
    }

    public void DogamBtnClick()
    {
        dogam_page.SetBool("Appear", true);
        Map.control_button.SetBool("Appear", false);
    }

    public void DogamCloseBtnClick()
    {
        dogam_page.SetBool("Appear", false);
        Map.control_button.SetBool("Appear", true);
        DogamManager.dogam_instance.DogamOpenButton.SetBool("Appear", true);
        DogamManager.dogam_instance.Boat1.SetBool("Appear", false);
        DogamManager.dogam_instance.Boat2.SetBool("Appear", false);
        DogamManager.dogam_instance.Boat3.SetBool("Appear", false);
        DogamManager.dogam_instance.Boat4.SetBool("Appear", false);
        DogamManager.dogam_instance.Boat5.SetBool("Appear", false);
    }

    public void DeptBtnClick()
    {
        dept_page.SetBool("Appear", true);
        Map.facility_button.SetBool("Appear", false);
    }

    public void FacilityBtnClick()
    {
        facility_page.SetBool("Appear", true);
        Map.dept_button.SetBool("Appear", false);
    }

    public void ControlBtnClick()
    {
        control_page.SetBool("Appear", true);
        Map.dogam_button.SetBool("Appear", false);
    }

    public void ControlCloseBtnClick()
    {
        control_page.SetBool("Appear", false);
        Map.dogam_button.SetBool("Appear", true);
    }


    public void FacilityCloseBtnClick()
    {
        facility_page.SetBool("Appear", false);
        Map.dept_button.SetBool("Appear", true);
    }
    

    public void DeptCloseBtnClick()
    {
        dept_page.SetBool("Appear", false);
        Map.facility_button.SetBool("Appear", true);
        Dept.money_to_pay_temp = 0;
    }
    


    public void RadioBtnClick()
    {
        //
    }

    ////////////////////////////////기능 함수///////////////////////////////////////////////////////////

    void TimeFlow() // 시간 지날때마다 아이콘 돌아가는거 8강 1시간3분에 있다.
    {
        Data.time_g += Time.deltaTime;

        if(Data.time_g >= 100f)
        {
            Data.num_boat = 0;
            //매달 배의 개수 0으로 초기화

            if (Data.month == 12) // 1month = 1minute
            {
                Data.year++;
                Data.month = 1;
            }
            else
            {
                Data.month++;
            }
            Data.time_g = 0;

            Data.num_boat = (Data.facility_light * 100) + (Data.facility_glass * 50) + (Count_ship())*(Data.facility_glass + Data.facility_light);
            Data.money_thismonth = (Data.num_boat);
            Data.money += (Data.num_boat);
            salary_page.SetBool("Appear", true);
            salary_button.SetBool("Appear", true);
            salary_text.SetBool("Appear", true);

            text_sal.text = "이번달 관측한 배의 개수 : " + Data.num_boat + "\n" + "이번달 월급 : " + Data.money_thismonth;

            Data.Ispause = true;
            
            // Time is stopped when salary page pop
        }
    }

    





    ////////////////
    ///

    
}

