using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SongManager : MonoBehaviour
{
    Enemy enemy;
    float songPosition, songPosInBeats, secPerBeat, dsptimesong;
    public int nextIndex = 0;
    float beatsShownInAdvance = 3;
    AudioClip audioClip;

    public SongInfo songInfo;
    // public SongCollection songCollection;
    public  SongStorage song;   
    public AudioSource localAudioSource;
    [SerializeField] GameObject[] prefabobj;
    [SerializeField] Transform[] ObjectPosition;
    public static float beatsShownOnScreen = 4f;

    void Start()
    {
        //    enemy = FindObjectOfType<EnemyManager>().enemy;
        // SongDataCollections(enemy);
        secPerBeat = 60f / song.Bpm;
        dsptimesong = (float)AudioSettings.dspTime;
        localAudioSource.clip = song.audioClip;
        localAudioSource.Play();
    }
    void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dsptimesong);
        Debug.Log(songPosInBeats);
        songPosInBeats = songPosition / secPerBeat + beatsShownInAdvance;
            Debug.Log("This");
        if (nextIndex < song.Notes.Length && song.Notes[nextIndex] < songPosInBeats)
        {
            int randomize = Random.Range(0, 4);
             GameObject gameObjectPrefab = Instantiate(prefabobj[0], ObjectPosition[randomize].position, ObjectPosition[randomize].rotation);
            gameObjectPrefab.transform.SetParent(ObjectPosition[randomize]);
            nextIndex++;
        } 
    }

    #region Sondatacollector 
    //void SongDataCollections(Enemy enemy)
    //{
    //    if (enemy == Enemy.goblin)
    //    {
    //        notesLength = songCollection.songSets[0].easy.tracks[0].notes.Length;
    //        audioClip = songCollection.songSets[0].easy.song;
    //        bpm = songCollection.songSets[0].easy.bpm;
    //        SongSetIndex = 0;
    //    }
    //    else if (enemy == Enemy.troll)
    //    {
    //        notesLength = songCollection.songSets[1].easy.tracks[0].notes.Length;
    //        audioClip = songCollection.songSets[1].easy.song;
    //        bpm = songCollection.songSets[1].easy.bpm;
    //        SongSetIndex = 1;
    //    }
    //}
    #endregion 
}