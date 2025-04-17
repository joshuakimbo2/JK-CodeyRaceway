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
        
        ///COUNTDOWN TIME START
        if (totalCountdownTime > 0) 
        {
            
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            
        }

        //COUNTDOWN TIME ENDS
        if (totalCountdownTime <= 0)
        {
            startCountdown.text = "";
            totalLapTime -= Time.deltaTime * 0.25f;
            lapTime.text = totalLapTime.ToString();
            cm.canMove = true;
        }

        ///LAP TIME
        if(totalLapTime <= 0)
        {
            print("Time is up!");
        }
    }
}
