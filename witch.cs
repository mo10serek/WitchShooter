using UnityEngine;
using System.Collections;

public class witch : MonoBehaviour {

    spots spot = new spots();

    public GameObject shot;
    public Transform shotSpawn;

    public Sprite _witch;
    public Sprite witch2;
    public Sprite witch3;
    public Sprite witch4;

    static int witchNumber = 4;
    static int witchNumber2 = 4;

    public bool growBoolean;
    private int growCounter = 1;

    // Use this for initialization
    void Start()
    {

    }

    public void shooting()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
    }

    void OnTriggerEnter(Collider shot) //defending function
    {
        Debug.Log(shot.name);
        Destroy(shot.gameObject);
    }

    public void moving(int touchPosition)
    {
        spot.spot(touchPosition);
    }
    public void grow()
    {
        

        if ((transform.localScale.x <= 0.35F) && (transform.localScale.y <= 0.35F))
        {
            transform.localScale += new Vector3(0.005f, 0.005f, 0);
           
        }
        else if (growCounter < 3)
        {
            transform.localScale = new Vector3(0.01f, 0.01f, 0);
            growCounter++;
        } 
        

    }
    void Update()
    {
        if (growBoolean == true)
        {
            grow();
        }
            
    }
    public void costume(int witchColor)
    {
        witchNumber = witchColor;
        
    }

    public void showCostume()
    {
        // this function makes the witch costume
        if (witchNumber == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = _witch;
        }
        else if (witchNumber == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = witch2;
        }
        else if (witchNumber == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = witch3;
        }
        else if (witchNumber == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = witch4;
        }
    }

    public void costume2(int witchColor)
    {
        witchNumber2 = witchColor;

    }

    public void showCostume2()
    {
        // this function makes the witch costume
        if (witchNumber2 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = _witch;
        }
        else if (witchNumber2 == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = witch2;
        }
        else if (witchNumber2 == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = witch3;
        }
        else if (witchNumber2 == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = witch4;
        }
    }
}
