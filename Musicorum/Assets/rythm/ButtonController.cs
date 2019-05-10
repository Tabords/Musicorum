using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour {

    [Header("Gauge Limiter")]
    [SerializeField] Slider GaugeLimit;
    [Header("image to show")]
    [SerializeField] Image whenPressBtn;
    public KeyCode keypress;
    bool checker;
    float Gaugelimiter;
    private float timer;
    private void Start()
    {
        checker = false;

    }
    private void Update()
    {
        if (Input.GetKeyDown(keypress))
        {
            whenPressBtn.enabled = true;
            checker = true;
        }if(Input.GetKeyUp(keypress))
        {
            whenPressBtn.enabled = false;
            checker = false;
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.up, out hit, 15))
        {
            if (hit.collider.tag == "BlockDrop")
            {
                if (checker)
                {
                    Debug.Log("destroyed");
                    GaugeLimit.value++;
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
   
}
