using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SongManager : MonoBehaviour
{
    EnemyManager enemyManager;
    float songPosition, songPosInBeats, secPerBeat, dsptimesong;
    public int nextIndex = 0;
    float beatsShownInAdvance = 3;
    AudioClip audioClip;

    public delegate void SongCompleted();
    public static event SongCompleted songComplete;

    GameManager gameManager;
    public  SongStorage[] song;       
    [Header("Audio Source:")]
    public AudioSource localAudioSource;
    [SerializeField] UnityEngine.GameObject[] prefabobj;
    [SerializeField] Transform[] ObjectPosition;
    public static float beatsShownOnScreen = 2f;
    int dis;
    void Start()
    {
        gameManager = GameManager.Instance;
        enemyManager = UnityEngine.GameObject.FindObjectOfType<EnemyManager>();


        switch (enemyManager.enemy)
        {
            case Enemy.OrcDagger:
                dis = 0;
                break;
            case Enemy.OrcSpear:
                dis = 1;
                break;
            case Enemy.OrcKing:
                dis = 2;
                break;
            case Enemy.WereWolf:
                dis = 3;
                break;
            case Enemy.WhiteWolf:
                dis = 4;
                break;
            case Enemy.BlackWolf:
                dis = 4;
                break;
            case Enemy.MiniBot:
                dis = 5;
                break;
            case Enemy.MegaBot:
                dis = 6;
                break;
        }
        Debug.Log(enemyManager.enemy);
        localAudioSource.clip = song[dis].audioClip;
        secPerBeat = 60f / song[dis].Bpm;
        dsptimesong = (float)AudioSettings.dspTime;
        localAudioSource.Play();
    }
    void Update()
    {
        songPosition = (float)(AudioSettings.dspTime - dsptimesong);
        songPosInBeats = songPosition / secPerBeat + beatsShownInAdvance;
        if (nextIndex < song[dis].Notes.Length && song[dis].Notes[nextIndex] < songPosInBeats)
        {
            int randomize = Random.Range(0, 4);
            GameObject gameObjectPrefab = Instantiate(prefabobj[randomize], ObjectPosition[randomize].position, ObjectPosition[randomize].rotation);
            gameObjectPrefab.transform.SetParent(ObjectPosition[randomize]);
            nextIndex++;
        }
        if (songPosition > song[dis].Notes.Length)
        {
            Debug.Log("songComplete");
            if (songComplete != null)
            {
                songComplete();
            }
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