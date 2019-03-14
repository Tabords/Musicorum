using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiation : MonoBehaviour {
    [SerializeField] UnityEngine.GameObject prefabObj;
    public UnityEngine.GameObject Instatiatedobj;
    private void Start()
    {
     Instatiatedobj = Instantiate(prefabObj);
    }
}
