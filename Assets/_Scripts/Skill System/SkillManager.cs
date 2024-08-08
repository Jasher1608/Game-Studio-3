using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : SerializedMonoBehaviour
{
    [SerializeField] ExperienceManager experienceManager;
    public void UpgradeSkill(Skill skill, Stats playerStats)
    {
        if (skill.currentLevel < skill.maxLevel)
        {
            if (experienceManager.currentGodInstance.skillPoints > 0)
            {
                skill.currentLevel++;

                if (skill.statModifiersByLevel.TryGetValue(skill.currentLevel, out List<StatModifier> modifiers))
                {
                    foreach (var modifier in modifiers)
                    {
                        playerStats.ChangeStat(modifier.stat, modifier.modifierValue);
                    }
                }

                experienceManager.currentGodInstance.skillPoints--;
            }
        }
    }
}