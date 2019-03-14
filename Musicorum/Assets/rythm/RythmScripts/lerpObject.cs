using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpObject : MonoBehaviour {

    [Header("Positions")]
    public Vector3 startMark, EndMark;
    Orc OrcAnimation;
    RectTransform rectTransform;
    public bool checker;
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        OrcAnimation = UnityEngine.GameObject.FindObjectOfType<Orc>();
        checker = true;
    }
    private void FixedUpdate()
    {
        float pos = transform.position.y;
        transform.position = new Vector3(transform.position.x, pos -= 6, transform.position.z);
        if (rectTransform.position.y < 22.679f)
        {
            checker = true;
            OrcAnimation.Attack(checker);
            Destroy(gameObject);
        }
    }
}
