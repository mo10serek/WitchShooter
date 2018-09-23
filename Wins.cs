using UnityEngine;
using System.Collections;

public class Wins : MonoBehaviour {

    public witch WinnerWitch;

    // Use this for initialization
    void Start () {

        if (Timer.wins == false)
        {
            WinnerWitch.showCostume();
        }
        else if (Timer.wins == true)
        {
            WinnerWitch.showCostume2();
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
