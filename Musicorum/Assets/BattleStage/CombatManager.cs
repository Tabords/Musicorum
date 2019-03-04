using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    
    public void RythmSystem()
    {
        GameManager.Instance.LoadRythmSystem();
    }

    public void Flee()
    {
        //sample
        GameManager.Instance.LoadLevelAsync("Stage1_Forest_Scene");
    }
    public void Potion() // access inventory later
    {

    }

    public void Defend()
    {


    }

}
