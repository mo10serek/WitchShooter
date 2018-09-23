using UnityEngine;
using System.Collections;

public class ChangingBackgrounds : MonoBehaviour {

    public Sprite background1;
    public Sprite background2;
    public Sprite background3;
    public Sprite background4;

    static int backgroundNumber = 1;

    void Start()
    {
        DisplayBackgrounds();
    }

    public void ChangeBackgrounds(int backgroundColor)
    {
        // this function makes the background
        backgroundNumber = backgroundColor;       
    }
    
    public void DisplayBackgrounds()
    {
        // this function sets the background
        if (backgroundNumber == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = background1;
        }
        else if (backgroundNumber == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = background2;
        }
        else if (backgroundNumber == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = background3;
        }
        else if (backgroundNumber == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = background4;
        }
    }

	
}