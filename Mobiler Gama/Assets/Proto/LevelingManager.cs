using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelingManager : MonoBehaviour
{
    /*[SerializeField]
    private GameObject characterPrefab;

    [SerializeField]
    private GameObject attacksPrefab;*/
    // For the full

    public int level;
    public float currentXp;
    public float requiredXp;

    private float lerpTimer;
    private float delayTimer;
    [Header("UI")]
    public Image LevelBarBack;
    public Image LevelBar;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI xpText;

    [Header("Multiplier")]
    [Range(1f,300f)]
    public float additionMultiplier = 300;
    [Range(2f, 4f)]
    public float powerMultiplier = 2;
    [Range(7f, 14f)]
    public float divisionMultiplier = 7;

    void Start()
    {
        LevelBarBack.fillAmount = currentXp / requiredXp;
        LevelBar.fillAmount = currentXp / requiredXp;
        requiredXp = CalculateRequiredXp();
        levelText.text = "Level" + level;
    }

    private void Update()
    {
        UpdateXpUI();
        if (Input.GetKeyDown(KeyCode.Equals))
            GainExperienceFlatRate(20);
        if (currentXp > requiredXp)
            LevelUp();
    }

    public void UpdateXpUI()
    {
        float xpFraction = currentXp / requiredXp;
        float FXP = LevelBar.fillAmount;
        if(FXP < xpFraction)
        {
            delayTimer += Time.deltaTime;
            LevelBarBack.fillAmount = xpFraction;
            if(delayTimer > 3)
            {
                lerpTimer += Time.deltaTime;
                float percentComplete = lerpTimer / 4;
                LevelBar.fillAmount = Mathf.Lerp(FXP, LevelBar.fillAmount, percentComplete);
            }
        }
        xpText.text = currentXp + "/" + requiredXp;
    }
    public void GainExperienceFlatRate(float xpGained)
    {
        currentXp += xpGained;
        lerpTimer = 0f;
    }

    public void LevelUp()
    {
        level++;
        LevelBar.fillAmount = 0f;
        LevelBarBack.fillAmount = 0f;
        currentXp = Mathf.RoundToInt(currentXp - requiredXp);
        GetComponent<CharacterStats>().IncreaseStats(level);
        requiredXp = CalculateRequiredXp();
        levelText.text = "Level" + level;
    }
    private int CalculateRequiredXp()
    {
        int solveForRequiredXp = 0;
        for(int levelCycle = 1; levelCycle <= level; levelCycle++)
        {
            solveForRequiredXp += (int)Mathf.Floor(levelCycle + additionMultiplier * Mathf.Pow(powerMultiplier, levelCycle / divisionMultiplier));
        }
        return solveForRequiredXp / 4;
    }
}
