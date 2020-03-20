using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeptManager : MonoBehaviour
{
    public DatabaseManager Data;

    public Text text_dept;
    public Text text_pay;
    public int money_to_pay_temp;

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        deptfunction();       
    }


    void deptfunction()
    {
        //money_to_pay_temp = Data.money_to_be_paid;
        text_dept.text = "갚아야 할 금액 : " + Data.money_to_be_paid;

        text_pay.text = money_to_pay_temp + "원";
    }

    public void deptOKbutton()
    {
        if (Data.money >= money_to_pay_temp)
        {
            Data.money_to_be_paid -= money_to_pay_temp;
            Data.money -= money_to_pay_temp;
            money_to_pay_temp = 0;
        }
    }

    public void one_button()
    {
        money_to_pay_temp += 1;
    }

    public void ten_button()
    {
        money_to_pay_temp += 10;
    }

    public void hundred_button()
    {
        money_to_pay_temp += 100;
    }

    public void thousand_button()
    {
        money_to_pay_temp += 1000;
    }
    
}
