using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpObject : MonoBehaviour
{
    private enum selector { orc, wolf, robot }
    selector selectors;
    [Header("Positions")]
    public Vector3 startMark, EndMark;
    EnemyManager enemyManager;
    RectTransform rectTransform;
    Orc OrcAnimation;
    wolf WolfAnimation;
    Robot RobotAnimation;
    public bool checker;
    private void Start()
    {
        enemyManager = FindObjectOfType<EnemyManager>();
        rectTransform = GetComponent<RectTransform>();
        OrcAnimation = GameObject.FindObjectOfType<Orc>();
        selectors = selector.orc;
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
