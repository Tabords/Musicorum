using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateChar : MonoBehaviour {

   private CharSelect charSelect;
    SavingPlayerPos savingPlayerPos;
    [Header ("Character prefabs")]
    [SerializeField] UnityEngine.GameObject[] CharacterPrefabs;
    [SerializeField] Transform Positions;
    UnityEngine.GameObject Character;

    public delegate void CharactedWasSelected();

    private void Start()
    {
        CharInstantiate();
    }
    private void OnDisable()
    {
        Destroy(gameObject);
        Destroy(Character);
    }
    public void CharInstantiate()
    {
        charSelect = UnityEngine.GameObject.FindObjectOfType<CharSelect>();
        if (charSelect.Charenum == choices.Kazu)
        {
            Character = Instantiate(CharacterPrefabs[0], Positions.transform.position, Positions.transform.rotation);
            Character.name = "Kazu";
            Character.tag = "Player";
        }
        if (charSelect.Charenum == choices.sophia)
        {
            Character = Instantiate(CharacterPrefabs[1], Positions.transform.position, Positions.transform.rotation);
            Character.name = "Sophia";
            Character.tag = "Player";
        }
        Character.transform.position = new Vector3(Positions.transform.position.x, Positions.transform.position.y, Positions.transform.position.z);
    }   
}
