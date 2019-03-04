using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PressAnyKey : MonoBehaviour
{
    [SerializeField] Text text;

    bool Checker;
    // Use this for initialization
    void Start()
    {
        Checker = false;
    }

    void Update()
    {
        if (!Checker)
        {
            if (Input.anyKey)
            {
                GameManager.Instance.LoadLevelAdditive("MainMenuScene");
                text.enabled = false;
                Checker = true;
            }
        }
    }
}
