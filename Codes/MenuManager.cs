using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Color BackColor;
    public GameObject UIGameSet;
    
    private void Start()
    {
    }
    
    public void ChangeBackground()
    {
        Camera.main.backgroundColor = BackColor;
    }

    public void PageBtnClick()
    {
        SceneManager.LoadScene("1 Main");
    }
}
