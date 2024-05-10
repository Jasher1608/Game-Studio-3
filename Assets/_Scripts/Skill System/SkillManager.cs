using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : SerializedMonoBehaviour
{
    [TableList]
    public SkillTree[] skillTrees;

    public void UpgradeSkill(Skill skill, Stats playerStats)
    {
        if (skill.currentLevel < skill.maxLevel)
        {
            skill.currentLevel++;
            
            if (skill.statModifiersByLevel.TryGetValue(skill.currentLevel, out List<StatModifier> modifiers))
            {
                foreach (var modifier in modifiers)
                {
                    playerStats.ChangeStat(modifier.stat, modifier.modifierValue);
                }
            }

            CheckForSynergies(skill, playerStats);
        }
    }

    private void CheckForSynergies(Skill skill, Stats playerStats)
    {
        foreach (var synergySkill in skill.synergies)
        {
            if (synergySkill.currentLevel > 0)
            {
                // Apply synergy effect
            }
        }
    }
}