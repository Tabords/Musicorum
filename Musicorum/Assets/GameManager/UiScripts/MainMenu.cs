using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public static MainMenu Instance;
    #region Singleton
    private void Awake()
    {
        Instance = this;
    }
    #endregion
    [SerializeField] Animator MainMenuAnimator;
    public void FadeIn()
    {
        MainMenuAnimator.SetBool("Show", false);
    }
    public void FadeOut()
    {
        UIManager.Instance.SetDummyCameraActive(false);
        MainMenuAnimator.SetBool("Show", true);
    }
}
