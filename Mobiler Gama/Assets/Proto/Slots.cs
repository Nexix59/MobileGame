using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private GetCharAct inventory;
    public int i;

    private void Start()
    {
        inventory = inventory.userCharacter.GetComponent<GetCharAct>();
    }

    private void Update()
    {
        if(transform.childCount <= 0)
        {
            inventory.isFull[i] = false;
        }
    }

    public void DropItem()
    {
        foreach (Transform userCharacter in transform)
        {
            GameObject.Destroy(gameObject);
        }
        Debug.Log("Transform");
    }
}
