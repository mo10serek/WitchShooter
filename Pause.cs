using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    public GameObject pauseMenu;
    public GameObject gold;
    public GameObject game;

    public bool paused;

    // Use this for initialization
    void Start () {
        paused = false;
    }

    public void MainMenu()
    {

        Application.LoadLevel("mainMenu");
    }

    public void Continue()
    {
        paused = false;
        pauseMenu.SetActive(false);
        game.SetActive(true);
        gold.SetActive(true);

    }

    public void pause()
    {
     
        paused = true;
        pauseMenu.SetActive(true);
        game.SetActive(false);
        gold.SetActive(false);
    }
}
   