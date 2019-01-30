using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum choices { none,Kazu, sophia }
public class CharSelect : MonoBehaviour {

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public choices Charenum;
    public void KazuSelected()
    {
            Charenum = choices.Kazu;
    }
    public void SophiaSelected()
    {
            Charenum = choices.sophia;
    }

}
