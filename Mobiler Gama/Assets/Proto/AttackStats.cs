using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AttackStats : MonoBehaviour
{
    [Header("Attack Stats")]
    [SerializeField] public float Damage;
    [SerializeField] public float accuracy;
    [SerializeField] public float reducedStamina;

    [Header("AtkElements")]
    [SerializeField] public bool Normal;
    [SerializeField] public bool Fire;
    [SerializeField] public bool Water;
    [SerializeField] public bool Grass;
    [SerializeField] public bool Earth;
    [SerializeField] public bool Dark;
    [SerializeField] public bool Light;
    [SerializeField] public bool Lightning;
    [SerializeField] public bool Magic;
    [SerializeField] public bool Metal;
    [SerializeField] public bool Legendary;

    private int Target;

    CharacterStats characterStats;
    [SerializeField] List<GameObject> Characters = new List<GameObject>();

    private void Awake()
    {
        characterStats = Characters[Target].GetComponent<CharacterStats>();
        Damage = characterStats.power + Damage + 3;
        Debug.Log(Target);
    }

    private void elementDmg()
    {
        // F I R E

        if (Fire && characterStats.isGrass && !characterStats.isWater && !characterStats.isFire)
        {
            Damage = Damage * 2f;
        } else if (Fire && characterStats.isWater && characterStats.isFire)
        {
            Damage = Damage * 0.5f;
        } else if (Fire && !characterStats.isGrass && !characterStats.isWater && !characterStats.isFire)
        {
            Damage = Damage * 1f;
        }

        // G R A S S

        if (Grass && characterStats.isMagic && !characterStats.isFire && !characterStats.isGrass)
        {
            Damage = Damage * 2f;
        } else if (Grass && characterStats.isFire && characterStats.isGrass)
        {
            Damage = Damage * 0.5f;
        } else if (Grass && !characterStats.isMagic && !characterStats.isFire && !characterStats.isGrass)
        {
            Damage = Damage * 1f;
        }

        // M A G I C

        if (Magic && characterStats.isMetal && !characterStats.isGrass && !characterStats.isMagic)
        {
            Damage = Damage * 2f;
        }
        else if (Magic && characterStats.isGrass && characterStats.isMagic)
        {
            Damage = Damage * 0.5f;
        }
        else if (Magic && !characterStats.isGrass && !characterStats.isMetal && !characterStats.isMagic)
        {
            Damage = Damage * 1f;
        }

        // M E T A L

        if (Metal && characterStats.isLight && !characterStats.isMagic && !characterStats.isMetal)
        {
            Damage = Damage * 2f;
        }
        else if (Metal && characterStats.isMagic && characterStats.isMetal)
        {
            Damage = Damage * 0.5f;
        }
        else if (Metal && !characterStats.isLight && !characterStats.isMagic && !characterStats.isMetal)
        {
            Damage = Damage * 1f;
        }

        // L I G H T

        if (Light && characterStats.isDark && !characterStats.isMetal && !characterStats.isLight)
        {
            Damage = Damage * 2f;
        }
        else if (Light && characterStats.isMetal && characterStats.isLight)
        {
            Damage = Damage * 0.5f;
        }
        else if (Light && !characterStats.isDark && !characterStats.isMetal && !characterStats.isLight)
        {
            Damage = Damage * 1f;
        }

        // D A R K

        if (Dark && characterStats.isEarth && !characterStats.isLight && !characterStats.isDark)
        {
            Damage = Damage * 2f;
        }
        else if (Light && characterStats.isLight && characterStats.isDark)
        {
            Damage = Damage * 0.5f;
        }
        else if (Light && !characterStats.isEarth && !characterStats.isLight && !characterStats.isDark)
        {
            Damage = Damage * 1f;
        }

        // E A R T H

        if (Earth && characterStats.isLightning && !characterStats.isDark && !characterStats.isEarth)
        {
            Damage = Damage * 2f;
        }
        else if (Light && characterStats.isDark && characterStats.isEarth)
        {
            Damage = Damage * 0.5f;
        }
        else if (Light && !characterStats.isLightning && !characterStats.isDark && !characterStats.isEarth)
        {
            Damage = Damage * 1f;
        }

        // L I G H T N I N G

        if (Lightning && characterStats.isWater && !characterStats.isEarth && !characterStats.isLightning)
        {
            Damage = Damage * 2f;
        }
        else if (Lightning && characterStats.isEarth && characterStats.isLightning)
        {
            Damage = Damage * 0.5f;
        }
        else if (Lightning && !characterStats.isWater && !characterStats.isEarth && !characterStats.isLightning)
        {
            Damage = Damage * 1f;
        }

        // W A T E R

        if (Water && characterStats.isFire && !characterStats.isLightning && !characterStats.isWater)
        {
            Damage = Damage * 2f;
        }
        else if (Lightning && characterStats.isLightning && characterStats.isWater)
        {
            Damage = Damage * 0.5f;
        }
        else if (Lightning && !characterStats.isFire && !characterStats.isLightning && !characterStats.isWater)
        {
            Damage = Damage * 1f;
        }

        // N O R M A L

        if (Normal)
        {
            Damage = Damage * 1f;
        }

        // L E G E N D A R Y

        if (Legendary)
        {
            Damage = Damage * 1f;
        }

    }

    private void Acurate()
    {
        int Digit = UnityEngine.Random.Range(0, 101);
        if (Digit <= accuracy) //if (RandNum <= 74 is like 74%
        {
            Damage = Damage * 0;
        }
        else
        {
            Damage = Damage * 1;
        }
    }

    //DAYGO FNNA GET ARCHETECTURAL

}
