using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePlayerPreprefs : MonoBehaviour
{
    RemovePlayerPreprefs instance;
    // Use this for initialization
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        PlayerPrefs.DeleteAll();
    }
}