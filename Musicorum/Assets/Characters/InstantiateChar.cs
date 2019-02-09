using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateChar : MonoBehaviour {

   private CharSelect charSelect;

    [SerializeField] GameObject[] CharacterPrefabs;
    [SerializeField] Transform[] Positions;
    GameObject Character;

    public delegate void CharactedWasSelected();
    public event CharactedWasSelected Charselec;

    private void Start()
    {
        
        charSelect = GameObject.FindObjectOfType<CharSelect>();
        if (charSelect.Charenum == choices.Kazu)
        {
            Character = Instantiate(CharacterPrefabs[0], Positions[0].transform.position, Positions[0].transform.rotation);
            Character.name = "Kazu";
            Character.tag = "Player";
            Debug.Log("Kazu Selected");
            OnKazu();
        }
        if (charSelect.Charenum == choices.sophia)
        {
            Character = Instantiate(CharacterPrefabs[1], Positions[0].transform.position, Positions[0].transform.rotation);
            Character.name = "Sophia";
            Character.tag = "Player";
            Debug.Log("sophia Selected");
            OnSophia();
        }
    }

    void OnKazu()
    {
        if (Charselec != null)
        {
            Charselec();
        }
    }

    void OnSophia()
    {
        if (Charselec != null)
        {
            Charselec();
        }
    }

    private void OnDisable()
    {
        Destroy(gameObject);
        Destroy(Character);
    }
}
