using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum choices { none,Kazu, sophia }
public class CharSelect : MonoBehaviour {



    public choices Charenum;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void KazuSelected()
    {
            Charenum = choices.Kazu;
    }
    public void SophiaSelected()
    {
            Charenum = choices.sophia;
    }
}
