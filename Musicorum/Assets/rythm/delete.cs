using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "3")
        {
            Destroy(collision.collider.gameObject);
        }
    }
}
