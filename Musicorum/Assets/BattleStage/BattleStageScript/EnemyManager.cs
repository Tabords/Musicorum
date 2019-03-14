using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Enemy { none, OrcDagger, OrcSpear,OrcKing, WhiteWolf,BlackWolf,WereWolf, MiniBot,MegaBot} // proceeds later 
public class EnemyManager : MonoBehaviour {

    public Enemy enemy;
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
