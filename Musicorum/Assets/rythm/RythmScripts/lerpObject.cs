using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpObject : MonoBehaviour {

    private void FixedUpdate()
    {
        float gpos = transform.position.y;
        transform.position = new Vector3(transform.position.x, gpos -= .5f, transform.position.z);
    }
}
