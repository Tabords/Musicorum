using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GaugeValue : MonoBehaviour {

    [SerializeField]
    Slider slider;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            slider.value++;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            slider.value = 0;
        }
    }
}
