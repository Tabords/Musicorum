using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Quest",menuName = "PlayerQuest")]
public class Quest_SO : ScriptableObject {
    //quest types
    //kill quest
    //item quest

    [Header("Quest Description")]
    public string Description;
    public string QuestType;

    [Header("Required to complete the Quest")]
    public int required;

    [Header("Current Progress of The Quest")]
    public int currentProgress;
}
