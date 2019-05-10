using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightDialog : MonoBehaviour
{

    [SerializeField] Text Speaker, Content;
    Quest quest;
    CharSelect charSelect;
    public Dialog_SO[] Message;
    int incDialog;
    int CurrentStage;
    bool DialogChecker;
    // Use this for initialization
    void Start()
    {
        incDialog = 0;
        DialogChecker = true;
        quest = Quest.instance;
        charSelect = UnityEngine.GameObject.FindObjectOfType<CharSelect>();
        Speaker.text = Message[quest.currentQuest].Dialog.messenger[incDialog];
        Content.text = Message[quest.currentQuest].Dialog.message[incDialog];
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(DialogChecker)
            {
                incDialog++;
                Dialog();
            }
        }
    }
    void Dialog()
    {
        Debug.Log(incDialog);
        if (incDialog < Message[quest.currentQuest].Dialog.message.Length)
        {
            Speaker.text = Message[quest.currentQuest].Dialog.messenger[incDialog];
            Content.text = Message[quest.currentQuest].Dialog.message[incDialog];
        }
        else
        {
            DialogChecker = false;
            Debug.Log(DialogChecker);
        }
    }
}
