using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject DummyCamera;

    public static UIManager Instance;
    // Use this for initialization
    #region Singleton
    private void Awake()
    {
       Instance = this;
    }
    #endregion
    public void SetDummyCameraActive(bool active)
    {
        DummyCamera.SetActive(active);
    }
}
