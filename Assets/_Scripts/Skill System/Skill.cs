using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "Skill System/Skill")]
public class Skill : SerializedScriptableObject
{
    [BoxGroup("Basic Settings"), LabelText("Skill Name")]
    public string skillName;

    [BoxGroup("Basic Settings"), Range(1, 10), LabelText("Max Level")]
    public int maxLevel = 3;

    [BoxGroup("Basic Settings"), ReadOnly, LabelText("Current Level")]
    public int currentLevel = 0;

    [BoxGroup("Basic Settings"), PreviewField]
    public Sprite icon;

    [BoxGroup("Basic Settings"), TextArea(4, 5)]
    public string description;

    [BoxGroup("Stat Modifiers"), InlineProperty, PropertyOrder(0)]
    [DictionaryDrawerSettings(KeyLabel = "Level", ValueLabel = "Modifiers")]
    public Dictionary<int, List<StatModifier>> statModifiersByLevel;
}
