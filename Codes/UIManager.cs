using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public DatabaseManager Data;
    public Text dateText;
    public Text moneyText;
    public Text numBoatText;

    void Start()
    {
        StartCoroutine("NowBoatNum");
    }

    int Count_ship2()
    {
        Data.random_n = Random.Range(1, 30);
        return Data.random_n;
    }

    void LateUpdate()
    {
        dateText.text = Data.year + "년" + string.Format("{0:d2}", Data.month) + "월";
        moneyText.text = "$" + string.Format("{0:n0}", Data.money)+"만원";
        
    }

    IEnumerator NowBoatNum()
    {
        while (true)
        {
            yield return new WaitForSeconds(4.0f);
            numBoatText.text = (((Data.facility_light * 100) + (Data.facility_glass * 50) + (Count_ship2()))/10).ToString();
        }
    }
}
