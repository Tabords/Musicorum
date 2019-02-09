using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour {


    Color Color;

    public KeyCode keypress;
    bool DestroyImage;
    // Use this for initialization
	void Start () {

       Color =  GetComponent<SpriteRenderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(keypress))
        {
            DestroyImage = true;
        }
        if (Input.GetKeyUp(keypress))
        {
            DestroyImage = false;
        }
	}
    private void FixedUpdate()
    {
       RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, Vector2.up,2f);
        if (raycastHit2D.collider.tag == "BlockDrop")
        {
            if (DestroyImage)
            {
                Debug.Log("Succ");
                Destroy(raycastHit2D.collider.gameObject);
            }
        }
        
    }

}
