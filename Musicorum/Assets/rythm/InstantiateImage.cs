using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateImage : MonoBehaviour {

    public UnityEngine.GameObject Prefab;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("enumerator");
        }
    }
    IEnumerator enumerator()
    {
        UnityEngine.GameObject PrefabImage = Instantiate(Prefab, transform.position, transform.rotation);
        float trans = Prefab.transform.position.y;
        PrefabImage.transform.SetParent(gameObject.transform);
        Prefab.AddComponent<Rigidbody2D>();
        PrefabImage.tag = "BlockDrop";

        yield return 0;
    }

}
