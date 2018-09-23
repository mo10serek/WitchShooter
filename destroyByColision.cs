using UnityEngine;
using System.Collections;

public class destroyByColision : MonoBehaviour {

    public ScoreHolder countScore;
    public AudioSource click;
    public AudioClip _break;

    // Use this for initialization
    void Start()
    {
        click = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider shot) {
        click.PlayOneShot(_break, 1);
        Destroy(shot.gameObject);
        Destroy(gameObject);
        countScore.holdScore = countScore.holdScore + 10;
    }
}
