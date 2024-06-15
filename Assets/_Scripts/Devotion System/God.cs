using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New God", menuName = "Skill System/God")]
public class God : ScriptableObject
{
    public string godName;
    public SkillTree skillTree;
    public int level;
    public float currentXP;
    public float xpToNextLevel;
}