using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour {

    [SerializeField] Animator animator;
    CharSelect charSelect;
    // Use this for initialization
    bool toSophia;
    bool toKazu;
	void Start () {
        animator = GetComponent<Animator>();
        charSelect = UnityEngine.GameObject.FindObjectOfType<CharSelect>();
        toSophia = toKazu = false;
	}

     void Update()
    {
        animator.SetBool("isToSophia", toSophia);
        animator.SetBool("isToKazu", toKazu);
   
    }
    // Update is called once per frame
    public void ToSophia()
    {
        toSophia = true;
        animator.SetBool("isToSophia", toSophia);
    }
    public void ToKazu()
    {
        toKazu = true;
        animator.SetBool("isToKazu", toKazu);
    }
    public void setSophia(bool sophia)
    {
        toSophia = sophia;   
    }
    public void SetKazu(bool kazu)
    {
        toKazu = kazu;
    }
    public void ConfirmBtn()
    {
        selected();
    }
    public void LoadStage(string levelname)
    {
        GameManager.Instance.LoadLevelAsync(levelname);
    }

    public void selected()
    {
        if (toSophia)
        {
            charSelect.Charenum = choices.sophia;
        }
        else if (toKazu)
        {
            charSelect.Charenum = choices.Kazu;
        }
    }
}
