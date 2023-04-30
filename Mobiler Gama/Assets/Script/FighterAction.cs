using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterAction : MonoBehaviour
{
    public GameObject enemy;
    public GameObject hero;

    [SerializeField]
    private GameObject meleePrefab;

    [SerializeField]
    private GameObject rangePrefab;

    [SerializeField]
    private Sprite faceIcon;

    private GameObject currentAttack;
    private GameObject meleeAttack;
    private GameObject rangeAttack;

    public void SelectAttack(string btn)
    {
        GameObject victim = hero;
        if (tag == "Hero")
        {
            victim = enemy;
        }
        if (btn.CompareTo("melee") == 0)
        {
            meleeAttack.GetComponent<AttackScript>().Attack(victim);

        } else if (btn.CompareTo("range") ==  0)
        
        {
            rangeAttack.GetComponent<AttackScript>().Attack(victim);
        } else
        {
            Debug.Log("Run");
        }
    }
}
