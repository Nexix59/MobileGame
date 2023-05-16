using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CharacterStats : MonoBehaviour
{
    [Header("Character Stats")]
    [SerializeField] public float maxHealth;
    [SerializeField] public float currentHealth;
    [SerializeField] public float Defense;
    [SerializeField] public float power;
    [SerializeField] public float speed;
    [SerializeField] public float maxStamina;
    [SerializeField] public float currentStamina;

    [Header("CharElements")]
    [SerializeField] public bool isFire;
    [SerializeField] public bool isWater;
    [SerializeField] public bool isGrass;
    [SerializeField] public bool isEarth;
    [SerializeField] public bool isDark;
    [SerializeField] public bool isLight;
    [SerializeField] public bool isLightning;
    [SerializeField] public bool isMagic;
    [SerializeField] public bool isMetal;
    [SerializeField] public bool isLegendary;

    [SerializeField] public List<GameObject> possibleActions = new List<GameObject>(21);

    [SerializeField] public List<GameObject> usableActions = new List<GameObject>(5);
        // usableAction will take from the list of possibleActions

    public bool dead = false;

    AttackStats attackStats;
    [SerializeField] GameObject attack;

    private void Awake()
    {
        attackStats = attack.GetComponent<AttackStats>();
        currentHealth = maxHealth;
        currentStamina = maxStamina;
    }

    private void recievedDamage()
    {
        currentHealth = currentHealth - (attackStats.Damage - Defense);
        if (currentHealth <= 0)
        {
            dead = true;
        }
        /*else if (damage > 0)
        {
            xNewHealthScale = healthScale.x * (health / startHealth);
            healthFill.transform.localScale = new Vector2(xNewHealthScale, healthScale.y);
        }
        if (damage > 0)
        {
            GameControllerObj.GetComponent<GameController>().battleText.gameObject.SetActive(true);
            GameControllerObj.GetComponent<GameController>().battleText.text = damage.ToString();
        }*/
    }

    public void usingAction()
    {
        if (attackStats.reducedStamina > currentStamina)
        {

        } else
        {

        }
    }

    public bool GetDead()
    {
        return dead;
    }

    public void IncreaseStats(int level)
    {
        maxHealth = currentHealth + 7;
        currentHealth = maxHealth;
        Defense = Defense + 2;
        maxStamina = currentStamina + 1;
        currentStamina = maxStamina;
        power = power + 12;
        speed = speed + 1;
    }
    
}
