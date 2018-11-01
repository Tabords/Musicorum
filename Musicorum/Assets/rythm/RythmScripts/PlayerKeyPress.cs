using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyPress : MonoBehaviour {

    [SerializeField] GameObject b1, b2, b3, b4;
    // Use this for initialization
    float referencezD,referenceF,referenceJ,referenceK;
	void Start () {
        referencezD = b1.transform.position.z;
        referenceF = b2.transform.position.z;
        referenceJ = b3.transform.position.z;
        referenceK = b4.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        float temposzD = b1.transform.position.z;
        float temposzF = b2.transform.position.z;
        float temposzJ = b3.transform.position.z;
        float temposzK = b4.transform.position.z;

        if (Input.GetKey(KeyCode.D))
        {
            b1.transform.position = new Vector3(b1.transform.position.x, b1.transform.position.y, temposzD + 3);
            Debug.Log("Pressed D: " + temposzD + " ");
        }
        else
        {
            b1.transform.position = new Vector3(b1.transform.position.x, b1.transform.position.y, referencezD);
        }


        if (Input.GetKeyDown(KeyCode.F) )
        {
            b2.transform.position = new Vector3(b2.transform.position.x, b2.transform.position.y, temposzF + 3);
            Debug.Log("Pressed F: " + temposzF + " ");
        }
        else
        {
            b2.transform.position = new Vector3(b2.transform.position.x, b2.transform.position.y, referenceF);
        }


        if (Input.GetKeyDown(KeyCode.J))
        {
            b3.transform.position = new Vector3(b3.transform.position.x, b3.transform.position.y, temposzJ);
            Debug.Log("Pressed J: " + temposzJ + " ");
        }
        else
        {
            b3.transform.position = new Vector3(b3.transform.position.x, b3.transform.position.y, referenceJ);
        }
    //    Input.GetKeyDown(KeyCode.D) ==  ? b1.transform.position = new Vector3(b1.transform.position.x, b1.transform.position.y, temposzD + 3) : b1.transform.position = new Vector3(b1.transform.position.x, b1.transform.position.y, referencezD);

    }
}
