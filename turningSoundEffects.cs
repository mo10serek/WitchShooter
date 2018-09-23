using UnityEngine;
using System.Collections;

public class turningSoundEffects : MonoBehaviour {

    public AudioSource click;
    public AudioClip sound;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;

    static bool soundEffects = true;
    static bool musicEffects = true;

    // Use this for initialization
    void Start()
    {
        click = GetComponent<AudioSource>();
    }
    public void turningOnOffSoundEffects(bool sound)
    {
        if (sound == false)
        {
            soundEffects = false;
        }
        if (sound == true)
        {
            soundEffects = true;
        }
    }

    public void turningOnOfMusicEffects(bool sound)
    {
        if (sound == false)
        {
            musicEffects = false;
        }
        if (sound == true)
        {
            musicEffects = true;
        }
    }



    public void displaySoundEffects(int soundType)
    {
        // this function display sound
        if (soundEffects == true)
        {
            if (soundType == 1)
            {
                click.PlayOneShot(sound, 1);
            }
            else if (soundType == 2)
            {
                click.PlayOneShot(sound1, 1);
            }
            else if (soundType == 3)
            {
                click.PlayOneShot(sound2, 1);
            }
            else if (soundType == 4)
            {
                click.PlayOneShot(sound3, 1);
            }
        }
        if (musicEffects == true) {
            if (soundType == 5)
            {
                click.PlayOneShot(sound, 1);
            }

        }
    }

}
