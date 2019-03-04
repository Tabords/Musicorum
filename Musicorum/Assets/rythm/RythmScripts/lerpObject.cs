using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpObject : MonoBehaviour {

    [Header("Positions")]
    public Vector3 startMark, EndMark;
    float journeyLength;
    private void Start()
    {
 //       journeyLength = Vector3.Distance(startMark, EndMark);
    }
    private void FixedUpdate()
    {
        //float distCovered = 3;
        //float fracJourney = distCovered / journeyLength;
        //transform.position = Vector3.Lerp(startMark, EndMark, fracJourney);
        float pos = transform.position.y;
        transform.position = new Vector3(transform.position.x, pos -= 6, transform.position.z);
    }
}
