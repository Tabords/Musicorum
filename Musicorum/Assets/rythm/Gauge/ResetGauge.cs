using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResetGauge : MonoBehaviour
{
    public int MaxGaugeValue;
    public int CurrentSliderValue;
    CharacterRaycast RayChar;
    private void Start()
    {
        RayChar = FindObjectOfType<CharacterRaycast>();
    }
    public void GaugeResetter(Slider slider)
    {
        if (slider.value >= slider.maxValue)
        {
            slider.value = 0;
            Debug.Log("calles her");
            RayChar.isAttack = true;
        }
    }
}
