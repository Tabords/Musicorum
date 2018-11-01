using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum PlayerSelected { none, kazu, Sophia }
public class DialogueControl : MonoBehaviour
{
    /*Needed Character Selection First
     * Add the Specific Audio placing
     * Add ImageSprites in KazuImages,SophiaImage,ArtImage
     * Script at DialogCanvas
     */
    enum Dialog { Player, Light, Narrator }
    Dialog dialog;
    PlayerSelected playerSelected;
    public Text ProfileName;
    public Text TextOutput;
    public AudioSource audioSource;
    public Image ArtPanel;
    public Sprite[] ProfileImage;
    public Sprite[] ImageSprite; //KazuImages, SophiaImages, ArtImages
    public AudioClip[] VoiceOver;
    [SerializeField] GameObject CharacterSelectionPanel;

    Text localText;
    string ProfileNameStr;
    float OffsetTime;
    public bool KazuIdentifier, SophiaIndetifier, NextPrompt;
    private int DialogInc = 0;

    // Use this for initialization
    void Start()
    {
        playerSelected = PlayerSelected.none;
        KazuIdentifier = SophiaIndetifier = false;
        NextPrompt = true;
        ProfileNameStr = "";
       
        
    }
    // Update is called once per frame
    void Update()
    {
        if (NextPrompt)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Talk();
            }
        }
        if (KazuIdentifier)
        {
            playerSelected = PlayerSelected.kazu;
            KazuIdentifier = false;
        }
        if (SophiaIndetifier)
        {
            playerSelected = PlayerSelected.Sophia;
            SophiaIndetifier = false;
        }
        Debug.Log(KazuIdentifier +" "+ KazuIdentifier);
    }
    public void Talk()
    {
        DialogInc += 1;
        if (playerSelected == PlayerSelected.kazu)
        {
            ProfileNameStr = "Kazu";
            ProfileName.text = ProfileNameStr;
        }
        if (playerSelected == PlayerSelected.Sophia)
        {
            ProfileNameStr = "Sophia";
            ProfileName.text = ProfileNameStr;
        }
        #region Prologue
        if (DialogInc == 1)
        {
            ProfileName.text = "Narrator";
            TextOutput.text = "Music an art so powerful you can change the world. So, what if you could use this power to save the world?";
            audioSource.clip = VoiceOver[0];
            audioSource.Play();
        }
        if (DialogInc == 2)
        {
            ProfileName.text = "Narrator";
            TextOutput.text = "Harmony University a school for prestigious students who excels in music. ";
            audioSource.clip = VoiceOver[2];
            audioSource.Play();
        }
        if (DialogInc == 3) //Show Art1 and Display the text. 
        {
            audioSource.Stop();
            //ArtPanel.sprite = ImageSprite[IndexOfArt1];
            TextOutput.text = "Kazu a child born in a poor family, got to study in Harmony University with the help school scholarship because of his talent.";
        }
        if (DialogInc == 4)
        {
            TextOutput.text = "Both are classmates and are equally placed as top 1 in the whole school.";
        }
        if (DialogInc == 5)
        {
            TextOutput.text = "But they wanted to prove people more that their skills is better than the other.";
        }
        if (DialogInc == 7)
        {
            //ArtPanel.sprite = ImageSprite[IndexofArt2];
            TextOutput.text = "One faithful day.....	Kazu and Sophia received a weird message...";
        }
        if (DialogInc == 8)//CharacterSelection
        {
            ProfileName.text = "";
            TextOutput.text = string.Empty;
            CharacterSelectionPanel.SetActive(true);
            NextPrompt = false;
        }
        #endregion
        #region Scene1
        if (DialogInc == 9) // only do when player Interact to the NPC!! 
        {
            CharacterSelectionPanel.SetActive(false);
            // MainMenu.Instance.FadeOut();
        }
        if (DialogInc == 10)
        {
            ProfileName.text = ProfileNameStr;
            TextOutput.text = "Where am I?I was reading a message on my phone awhile ago.";
            if (playerSelected == PlayerSelected.Sophia)
            {
                audioSource.clip = VoiceOver[1];
            } else if (playerSelected == PlayerSelected.kazu)
            {
                audioSource.clip = VoiceOver[18];
            }
            audioSource.Play();
        }
        if (DialogInc == 11)
        {
            ProfileName.text = "Light";
            TextOutput.text = "Welcome chosen ones to I see your love and passion about your music.";
            audioSource.clip = VoiceOver[19];
            audioSource.Play();
        }
        if (DialogInc == 12)
        {
            ProfileName.text = ProfileNameStr;
            TextOutput.text = "I feel dizzy... who are you?";
            if (playerSelected == PlayerSelected.Sophia)
            {
                audioSource.clip = VoiceOver[3];
            }
            else if (playerSelected == PlayerSelected.kazu)
            {
                audioSource.clip = VoiceOver[20];
            }
            audioSource.Play();
        }
        if (DialogInc == 13)
        {
            ProfileName.text = "Light";
            TextOutput.text = "I am Light guardian of dimensions, you have been chosen to protect Earth from Invasion.";
            audioSource.clip = VoiceOver[21];
            audioSource.Play();
        }
        if (DialogInc == 14)
        {
            ProfileName.text = ProfileNameStr;
            TextOutput.text = "Ligth? Invasion? FROM WHAT!?";
            if (playerSelected == PlayerSelected.Sophia)
            {
                audioSource.clip = VoiceOver[5];
            }
            else if (playerSelected == PlayerSelected.kazu)
            {
                audioSource.clip = VoiceOver[22];
            }
            audioSource.Play();
        }
        if (DialogInc == 15)
        {
            ProfileName.text = "Light";
            TextOutput.text = "Invasion from three worlds by corrupted species invades other worlds. They plan to combine three of the musicorum crystals in order to create a portal connects to earth.";
            audioSource.clip = VoiceOver[23];
            audioSource.Play();
        }
        if (DialogInc == 16)
        {
            ProfileName.text = ProfileNameStr;
            TextOutput.text = "That doesn't sound safe...";
            if (playerSelected == PlayerSelected.Sophia)
            {
                audioSource.clip = VoiceOver[7];
            }
            else if (playerSelected == PlayerSelected.kazu)
            {
                audioSource.clip = VoiceOver[24];
            }
            audioSource.Play();
        }
        if (DialogInc == 17)
        {
            ProfileName.text = ProfileNameStr;
            TextOutput.text = "Musicorum crystal?";
            if (playerSelected == PlayerSelected.Sophia)
            {
                audioSource.clip = VoiceOver[9];
            }
            else if (playerSelected == PlayerSelected.kazu)
            {
                audioSource.clip = VoiceOver[26];
            }
            audioSource.Play();
        }
        if (DialogInc == 18)
        {
            ProfileName.text = "Light";
            TextOutput.text = "Crystals that emit strong sound waves. And if one was to combine 3 of this the sound wave could open a portal connecting to any world the user wants.";
            audioSource.clip = VoiceOver[25];
            audioSource.Play();
        }
        if (DialogInc == 19)
        {
            ProfileName.text = ProfileNameStr;
            TextOutput.text = "Ugh..why me? I don't even know how to fight.";
            if (playerSelected == PlayerSelected.Sophia)
            {
                audioSource.clip = VoiceOver[11];
            }
            else if (playerSelected == PlayerSelected.kazu)
            {
                audioSource.clip = VoiceOver[28];
            }
            audioSource.Play();
        }
        if(DialogInc == 20)
        {
            ProfileName.text = "Light";
            TextOutput.text = "You are posses a power greater than fighting and that is playing music with heart";
            audioSource.clip = VoiceOver[27];
            audioSource.Play();
        }
        if (DialogInc == 21)
        {
            ProfileName.text = ProfileNameStr;
            
            if (playerSelected == PlayerSelected.Sophia)
            {
                TextOutput.text = "Music? Fine.. But I only got my guitar with me";
                audioSource.clip = VoiceOver[13];
            }
            else if (playerSelected == PlayerSelected.kazu)
            {
                TextOutput.text = "But I only got 2 drumsticks with me";
                audioSource.clip = VoiceOver[30];
            }
            audioSource.Play();
        }
        if (DialogInc == 22)
        {
            ProfileName.text = "Light";
            TextOutput.text = "I got you covered";
            audioSource.clip = VoiceOver[29];
            audioSource.Play();
        }
        if (DialogInc == 23)
        {
            ProfileName.text = ProfileNameStr;
            TextOutput.text = "I'll do my best!!!";
            if (playerSelected == PlayerSelected.Sophia)
            {
                audioSource.clip = VoiceOver[14];
            }
            else if (playerSelected == PlayerSelected.kazu)
            {
                audioSource.clip = VoiceOver[31];
            }
            audioSource.Play();
        }
        if (DialogInc == 24)
        {
            ProfileName.text = "Narrator";
            TextOutput.text = "Those are goblins,defeat them in order to open the wall protecting the crystal";
            audioSource.clip = VoiceOver[4];
            audioSource.Play();
        }
        if(DialogInc == 25)
        {
            ProfileName.text = ProfileNameStr;
            TextOutput.text = "They look scary...";
            if (playerSelected == PlayerSelected.Sophia)
            {
                audioSource.clip = VoiceOver[15];
            }
            else if (playerSelected == PlayerSelected.kazu)
            {
                audioSource.clip = VoiceOver[32];
            }
            audioSource.Play();
        }
        #endregion
    }
    public void KazuCharacterSelected(bool Prompt)
    {
        KazuIdentifier = Prompt;
        NextPrompt = Prompt;
    }
    public void SophiaCharacterSelected(bool Prompt)
    {
        SophiaIndetifier = Prompt;
        NextPrompt = Prompt;
    }
}
