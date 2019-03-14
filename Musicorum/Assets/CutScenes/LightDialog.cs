using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightDialog : MonoBehaviour {

    [SerializeField] Text Speaker, Content;

    CharSelect charSelect;
    int incDialog;
    // Use this for initialization
	void Start () {
        incDialog = 1;
        charSelect = UnityEngine.GameObject.FindObjectOfType<CharSelect>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dialog();
        }
	}

    void Dialog()
    {

        if (incDialog == 1)
        {
            if (charSelect.Charenum == choices.Kazu)
            {
                Speaker.text = "Kazu";
            }
            if (charSelect.Charenum == choices.sophia)
            {
                Speaker.text = "Sophia";
            }
            Content.text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s";
        }
        if (incDialog == 2)
        {
            Speaker.text = "Light";
            Content.text = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters";
        }

        if (incDialog == 3)
        {
            if (charSelect.Charenum == choices.Kazu)
            {
                Speaker.text = "Kazu";
            }
            if (charSelect.Charenum == choices.sophia)
            {
                Speaker.text = "Sophia";
            }
            Content.text = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour";
        }
        incDialog++;
    }
}
