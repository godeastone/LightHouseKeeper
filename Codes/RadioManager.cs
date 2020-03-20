using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea(1, 8)]
    public string sentences;
    public bool is_success;
}

public class RadioManager : MonoBehaviour
{
    public DatabaseManager Data;
    public TransferMap Transfer;

    public List<Dialogue> listSentences;
    public Dialogue dialogue;
    //public Animator animDialogueWindow;
    public Text text;

    public int count;
    private bool talking;
    

    // Start is called before the first frame update
    void Start()
    {
        text.text = "";
        talking = false;
        count = -1;
    }

    public void RadioClick()
    {
        if (talking == false)
        {
            count = Random.Range(0, listSentences.Count);
            listSentences[count].is_success = false;
            text.text = "";
            Data.quest_ing = true;
            StartCoroutine(RadioStart());
        }
    }

    private void EndRadio()
    {
        Transfer.radio_window.SetBool("Appear", false);
        //animDialogueWindow.SetBool("Appear", false);
        text.text = "";
        Data.quest_ing = false;
        talking = false;
        count = -1;

    }

    IEnumerator RadioStart()
    {
        talking = true;
        Transfer.radio_window.SetBool("Appear", true); 
        //animDialogueWindow.SetBool("Appear", true);
        for (int i = 0; i < listSentences[count].sentences.Length; i++)
        {
            text.text += listSentences[count].sentences[i];
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(15.0f);
        Debug.Log("Failed");
        EndRadio();
        StopAllCoroutines();
    }

    


    void Update()
    {
        if (count != -1 && listSentences[count].is_success == true)
        {
            Data.money += Data.facility_light * 20 + Data.facility_glass * 23;
            Debug.Log("Success");
            StopAllCoroutines();
            listSentences[count].is_success = false;
            EndRadio();
        }
    }

}
