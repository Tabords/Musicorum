using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiation : MonoBehaviour {
    [SerializeField] GameObject prefabObj;
    public GameObject Instatiatedobj;
    private void Start()
    {
     Instatiatedobj = Instantiate(prefabObj);
    }
}
