using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AlertScript : MonoBehaviour
{

    private static TMPro.TextMeshProUGUI title;
    private static TMPro.TextMeshProUGUI message;
    private static TMPro.TextMeshProUGUI button;
    private static GameObject content;
    private static Action action;
    public static void Show(string title, string message, string actionButtonText = "Close", Action action = null)
    {
       AlertScript.title.text = title;
       AlertScript.message.text = message;
       AlertScript.button.text = actionButtonText;
       AlertScript.action = action;
       content.SetActive(true);
       Time.timeScale = 0.0f;
    }



    void Start()
    {
        Transform c = transform.Find("Content");
        title = c.Find("Title").GetComponent<TMPro.TextMeshProUGUI>();
        message = c.Find("Message").GetComponent<TMPro.TextMeshProUGUI>();
        button = c.Find("Button/Text").GetComponent<TMPro.TextMeshProUGUI>();
        content = c.gameObject;
        content.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            //  content.SetActive(false);
            //  Time.timeScale = 1.0f;
            OnActionButtonClick();

        }
    }


    public void OnActionButtonClick()
    {
        content.SetActive(false);
        Time.timeScale = 1.0f;  
        DestroyerScript.ClearField();

        if(action != null)
        {
            action();
        }
    }
}
