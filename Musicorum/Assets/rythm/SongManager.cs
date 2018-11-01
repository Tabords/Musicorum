using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SongManager : MonoBehaviour
{
    float songPosition, songPosInBeats, secPerBeat, dsptimesong;
    public int nextIndex = 0;
    
    float beatsShownInAdvance;
    public SongStorage NotesPosition;
    public AudioSource localAudioSource;
    [SerializeField] GameObject prefabobj;
    [SerializeField] Transform[] ObjectPosition;
    void Start()
    {
        beatsShownInAdvance = 0.2f;
        secPerBeat = 60f / NotesPosition.Bpm;
        dsptimesong = (float)AudioSettings.dspTime;
        localAudioSource.clip = NotesPosition.audioClip;
        localAudioSource.Play();
    }
    private void FixedUpdate()
    {
        songPosition = (float)(AudioSettings.dspTime - dsptimesong);
        songPosInBeats = songPosition / secPerBeat;
        if (nextIndex < NotesPosition.Notes.Length && NotesPosition.Notes[nextIndex] < songPosInBeats + beatsShownInAdvance)
        {
            int randomize = Random.Range(0, 4);
            Instantiate(prefabobj, ObjectPosition[randomize].position, ObjectPosition[randomize].rotation);
            nextIndex++;
        }

    }
}