using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackScript : MonoBehaviour
{
    public GameObject owner;

    [SerializeField]
    private string animationName;

    [SerializeField]
    private bool magicAttack;

    [SerializeField]
    private float magicCost;

    [SerializeField]
    private float minAttackMultiplier;

    [SerializeField]
    private float maxAttackMultiplier;

    [SerializeField]
    private float minDefenseMultiplier;

    [SerializeField]
    private float maxDefenseMultiplier;

    private FighterStats attackerStats;
    private FighterStats targetStats;
    private float damage = 0.0f;
    
    public void Attack(GameObject victim)
    {
        attackerStats = owner.GetComponent<FighterStats>();
        targetStats = victim.GetComponent<FighterStats>();
        if(attackerStats.magic >= magicCost)
        {
            float multiplier = Random.Range(minAttackMultiplier, maxAttackMultiplier);

            damage = multiplier * attackerStats.attack;
            if (magicAttack)
            {
                damage = multiplier * attackerStats.range;
            }

            float defenseMultiplier = Random.Range(minDefenseMultiplier, maxDefenseMultiplier);
            damage = Mathf.Max(0, damage - (defenseMultiplier * targetStats.defense));
            owner.GetComponent<Animator>().Play(animationName);
            targetStats.ReceiveDamage(Mathf.CeilToInt(damage));
            attackerStats.updateMagicFill(magicCost );
        } else
        {
            Invoke("SkipTurnContinueGame", 2);
        }
    }

    void SkipTurnContinueGame()
    {
        GameObject.Find("GameControllerObject").GetComponent<GameController>().NextTurn();
    }
}


