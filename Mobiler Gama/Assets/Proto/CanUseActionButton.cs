using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanUseActionButton : MonoBehaviour
{
    public bool actionSet;
    CharacterStats characterStats;
    public GameObject userCharacter;
    //[SerializeField] List<GameObject> Characters = new List<GameObject>(0);
    [SerializeField] int CharAction = 0;

    private GetCharAct inventory;
    public GameObject actionButton;
    public GameObject actionProfile;

    private void Awake()
    {
        //inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        inventory = userCharacter.GetComponent<GetCharAct>();

        // make an if to prevent adding more than five
        if (actionSet)
        {

            userCharacter.GetComponent<CharacterStats>().possibleActions.Remove(userCharacter.GetComponent<CharacterStats>().possibleActions[CharAction]);
            // add an action from group 21 to group 5
        }
        else if (!actionSet)
        {
            //userCharacter.GetComponent<CharacterStats>().possibleActions.Insert(userCharacter.GetComponent<CharacterStats>().possibleActions[CharAction]);
            //userCharacter.GetComponent<CharacterStats>().possibleActions[CharAction].SetActive(false);
            // delete inserted 21 group from group 5
        }
        Debug.Log(actionSet);
    }

    public void PutIOAction()
    {
        //userCharacter.GetComponent<CharacterStats>().possibleActions.
        //Remove(userCharacter.GetComponent<CharacterStats>().possibleActions[CharAction]);
        if (actionButton) {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(actionProfile, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
        Debug.Log(inventory.slots.Length);
            //userCharacter.GetComponent<CharacterStats>().possibleActions.
            //  Insert(userCharacter.GetComponent<CharacterStats>().possibleActions[CharAction]);
    }

    public void ActiveIt(bool Drp)
    {
        
        if (Drp)
        {
            userCharacter.GetComponent<CharacterStats>().possibleActions[CharAction].SetActive(true);
        }
        else
        {
            userCharacter.GetComponent<CharacterStats>().possibleActions[CharAction].SetActive(false);
        }
        Debug.Log(Drp);
        
    }
}
