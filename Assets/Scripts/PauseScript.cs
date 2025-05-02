using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{

    private GameObject content;
    void Start()
    {
        Transform c = transform.Find("Content");
        content = c.gameObject;

             if(content.activeInHierarchy)
             {
                Time.timeScale = 0.0f;
             }
    }
    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
             if(content.activeInHierarchy)
             {
                content.SetActive(false);
                Time.timeScale = 1.0f;
             }

             else{
                 content.SetActive(true);
                Time.timeScale = 0.0f;
             }
        }
    }

    public void OnButtonClick()
    {
         content.SetActive(false);
         Time.timeScale = 1.0f;
    }

        public void OnIntervalValueChanged(System.Single value)
        {
             SpawnerScript.difficulty = value;
        }

        public void OnPipeDistanceChanged(float value)
         {
               SpawnerScript.pipeDistance = value;
         }

}
