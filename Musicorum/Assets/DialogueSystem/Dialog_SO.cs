using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialog", menuName = "DialogToShow")]
public class Dialog_SO : ScriptableObject
{
    public int CurrentStage;
    public Message Dialog;

    [Serializable]
    public class Message
    {
        public string[] messenger, message;
    }
}
