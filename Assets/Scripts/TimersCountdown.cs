using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public CodeyMove cm;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;


    // Update is called once per frame
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
        if (totalCountdownTime > 0) 
        { 
        totalCountdownTime -= Time.deltaTime;
        startCountdown.text = totalCountdownTime.ToString();
            cm.Speed = 0;
        }

        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime;
            lapTime.text = totalLapTime.ToString();
            cm.Speed = 60;
        }
        if(totalLapTime <= 0)
        {
            print("Time is up!");
        }

            
    }
    
}
