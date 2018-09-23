using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreHolder : MonoBehaviour {

    public int holdScore = 0;
    public Text score;

    // Use this for initialization
    protected void Start()
    {

        score.text = "score " + holdScore;
    }

    // Update is called once per frame
    public void Update()
    {

        score.text = "score " + holdScore;
    }
}
