using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill Tree", menuName = "Skill System/Skill Tree")]
public class SkillTree : SerializedScriptableObject
{
    [InlineEditor(Expanded = true)]
    public Skill[] skills;

    [BoxGroup("Tree Info"), LabelText("Skill Tree Name")]
    public string treeName;
}
