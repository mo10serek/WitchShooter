using UnityEngine;
using System.Collections;

public class spots : MonoBehaviour {

    public GameObject witch;
    private Vector3 player1position = new Vector3(-3, -2, 0);
    private Vector3 player1position1 = new Vector3(-2, -2, 0);
    private Vector3 player1position2 = new Vector3(-1, -2, 0);
    private Vector3 player1position3 = new Vector3(0, -2, 0);
    private Vector3 player1position4 = new Vector3(1, -2, 0);
    private Vector3 player1position5 = new Vector3(2, -2, 0);
    private Vector3 player1position6 = new Vector3(3, -2, 0);
    private Vector3 player1position7 = new Vector3(4, -2, 0);

    private Vector3 player2position = new Vector3(-3, 2, 0);
    private Vector3 player2position1 = new Vector3(-2, 2, 0);
    private Vector3 player2position2 = new Vector3(-1, 2, 0);
    private Vector3 player2position3 = new Vector3(0, 2, 0);
    private Vector3 player2position4 = new Vector3(1, 2, 0);
    private Vector3 player2position5 = new Vector3(2, 2, 0);
    private Vector3 player2position6 = new Vector3(3, 2, 0);
    private Vector3 player2position7 = new Vector3(4, 2, 0);

    public void spot (int touchPosition)
    {
        if (touchPosition == 0)
        {
            witch.transform.position = player1position;
            
        }
        if (touchPosition == 1)
        {
            witch.transform.position = player1position1;
      
        }
        if (touchPosition == 2)
        {
            witch.transform.position = player1position2;
            

        }
        if (touchPosition == 3)
        {
            witch.transform.position = player1position3;
           
        }
        if (touchPosition == 4)
        {
            witch.transform.position = player1position4;
            
        }
        if (touchPosition == 5)
        {
            witch.transform.position = player1position5;
            
        }
        if (touchPosition == 6)
        {
            witch.transform.position = player1position6;
            
        }
        if (touchPosition == 7)
        {
            witch.transform.position = player1position7;
            
        }
        if (touchPosition == 8)
        {
            witch.transform.position = player2position;
            
        }
        if (touchPosition == 9)
        {
            witch.transform.position = player2position1;
            
        }
        if (touchPosition == 10)
        {
            witch.transform.position = player2position2;
            
        }
        if (touchPosition == 11)
        {
            witch.transform.position = player2position3;
           
        }
        if (touchPosition == 12)
        {
            witch.transform.position = player2position4;
            
        }
        if (touchPosition == 13)
        {
            witch.transform.position = player2position5;
            
        }
        if (touchPosition == 14)
        {
            witch.transform.position = player2position6;
            
        }
        if (touchPosition == 15)
        {
            witch.transform.position = player2position7;
            
        }
    }
}
