using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPlayerPos : MonoBehaviour
{

    float px, py, pz;
    CurrentLoadedScene current;
    // Use this for initialization
    public PlayerPosition_SO[] PlayerDefaultPositions;
    int defaultnum;
    private void OnDestroy()
    {
        SetPlayerPos();
    }
    private void Awake()
    {
            current = CurrentLoadedScene.instance;
    }
    void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("posx", -26.15922f), PlayerPrefs.GetFloat("posy", 2.51f), PlayerPrefs.GetFloat("posz", -35.37441f));
    }
    public void SetPlayerPos()
    {
        PlayerPrefs.SetFloat("posx", transform.position.x);
        PlayerPrefs.SetFloat("posy", transform.position.y); 
        PlayerPrefs.SetFloat("posz", transform.position.z);
        PlayerPrefs.Save();
    }
    public void WhenDied(int die)
    {
        defaultnum = die;         
    }

}
