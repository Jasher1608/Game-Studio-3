using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Stats")]
public class Stats : SerializedScriptableObject
{
    public Dictionary<Stat, float> stats = new Dictionary<Stat, float>();

    public float GetStat(Stat stat)
    {
        if (stats.TryGetValue(stat, out float value))
        {
            return value;
        }
        else
        {
            Debug.LogError($"No stat value found for {stat} on {this.name}");
            return 0;
        }
    }

    public float ChangeStat(Stat stat, float amount)
    {
        if (stats.TryGetValue(stat, out float value))
        {
            stats[stat] += amount;
            return stats[stat];
        }
        else
        {
            return -1f;
        }
    }
}