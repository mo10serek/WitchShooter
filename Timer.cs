using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public float timeCounter;
    public ScoreHolder witchScore1;
    public ScoreHolder witchScore2;

    public static bool wins;

    public Pause stopTimer;
    public Text timeText;

    // Use this for initialization
    void Start () {

        timeCounter = 60;
    }

    // Update is called once per frame
    void Update() {

        if (stopTimer.paused == false)
        {
            timeCounter -= Time.deltaTime;
        }

        if (timeCounter > -1)
        {
            timeText.text = "time: " + (int)timeCounter + "s";
        } else {
            Application.LoadLevel("finishGame");

            if (witchScore1.holdScore > witchScore2.holdScore) {
                wins = false;
            } else {
                wins = true;
            }

        } 

        
	
    }

}
