using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimeStop : MonoBehaviour
{
    private TimeManager timemanager;

    // Start is called before the first frame update
    void Start()
    {
        //timemanager = GameObject.FindGameObjectWithTag("TimeManager").GetComponent<TimeManager>();
        timemanager = GameObject.FindObjectOfType<TimeManager>().GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //Stop Time when Q is pressed
        {
            //Time.timeScale = 0;
            timemanager.StopTime();
            
            // Grayscale.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && timemanager.TimeIsStopped)  //Continue Time when E is pressed
        {
            timemanager.ContinueTime();
            // Grayscale.enabled = false;
        }
    }
}
