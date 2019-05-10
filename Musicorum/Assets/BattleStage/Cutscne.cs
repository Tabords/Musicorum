using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cutscne : MonoBehaviour
{

    [SerializeField] Sprite[] CutSceneSprites;
    [SerializeField]
    Image ImageHolder;
    int SpriteChecker;
    void Start()
    {
        ImageHolder.sprite = CutSceneSprites[0];
        SpriteChecker = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ImageSet();
            Debug.Log("SPritechecker: " + SpriteChecker);
        }

    }

    void ImageSet()
    {
        SpriteChecker++;
        if (SpriteChecker < CutSceneSprites.Length)
        {

            ImageHolder.sprite = CutSceneSprites[SpriteChecker];
        }
    }
}
