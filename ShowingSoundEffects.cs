using UnityEngine;
using System.Collections;

public class ShowingSoundEffects : MonoBehaviour {

    public turningSoundEffects _showingSoundEffects;
    public int setSound;

    // Use this for initialization
    void Start () {

        _showingSoundEffects.displaySoundEffects(setSound);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
