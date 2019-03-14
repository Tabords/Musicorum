using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePlayerPreprefs : MonoBehaviour
{

    // Use this for initialization
    private void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
}