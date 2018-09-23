using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {
	
    public bool leftOrRight = true;

	// Update is called once per frame
	void Update () {
        if (leftOrRight == true) {
            transform.position += new Vector3(0, 1, 0) / 20;
        } else {
            transform.position -= new Vector3(0, 1, 0) / 20;
        }
        
    }
}
