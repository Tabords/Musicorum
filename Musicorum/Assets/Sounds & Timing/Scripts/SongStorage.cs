using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName = "SongData", menuName = "Scriptable")]
public class SongStorage : ScriptableObject
{

    public string Name;
    public float Bpm;
    public AudioClip audioClip;
    public float[] Notes;

}
