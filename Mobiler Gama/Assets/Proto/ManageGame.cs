using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;

public class ManageGame : MonoBehaviour
{
    [SerializeField] List<GameObject> leftSide = new List<GameObject>();
        //GameObject[] leftSide = new GameObject[4];

    [SerializeField] List<GameObject> rightSide = new List<GameObject>();

    public GameObject actionMenu;

    private void Start()
    {
        /*if (currentUnit.tag == "Hero")
        {
            this.battleMenu.SetActive(true);
        }*/
        //Debug.Log(Turn);
    }
    private void Update()
    {
        
    }
    private void battleStates(bool inEnemyState, bool inHeroState)
    {
        if (inEnemyState)
        {
            actionMenu.SetActive(false);
        }
        else if (inHeroState)
        {
            actionMenu.SetActive(true);
        }
    }


}
