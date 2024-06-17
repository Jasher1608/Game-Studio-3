using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodInstance
{
    public God god;
    public int level;
    public float currentXP;
    public float xpToNextLevel;
    public int skillPoints;
    public int investedSkillPoints;

    public GodInstance(God god)
    {
        this.god = god;
        level = 0;
        currentXP = 0;
        xpToNextLevel = CalculateNextLevelXP();
        skillPoints = 0;
        investedSkillPoints = 0;
    }

    public void AddExperience(float amount)
    {
        currentXP += amount;
        if (currentXP >= xpToNextLevel)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        level++;
        currentXP -= xpToNextLevel;
        xpToNextLevel = CalculateNextLevelXP();
        skillPoints += 1;
    }

    private float CalculateNextLevelXP()
    {
        return 20 + (level * 10) + Mathf.Pow(level, 1.2f) * 5;
    }
}