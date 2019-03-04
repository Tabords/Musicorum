using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPlayerPos : MonoBehaviour {

    public PlayerPosition_SO PlayerPosition;
    float px, py, pz;
    // Use this for initialization

    private void OnDestroy()
    {
        SetPlayerPos();
    }
 
    void Start () {
        transform.position = new Vector3(PlayerPrefs.GetFloat("posx", -26.15922f), PlayerPrefs.GetFloat("posy", 1.62f), PlayerPrefs.GetFloat("posz", -35.37441f));
    }
    public void SetPlayerPos()
    {
        PlayerPrefs.SetFloat("posx", transform.position.x);
        PlayerPrefs.SetFloat("posy", transform.position.y);
        PlayerPrefs.SetFloat("posz", transform.position.z);
    }
 
}
