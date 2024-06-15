using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
    public Dictionary<God, GodInstance> godInstances = new Dictionary<God, GodInstance>();
    public GodInstance currentGodInstance;
    public float totalXP;

    public void GainExperience(float amount)
    {
        totalXP += amount;
        if (currentGodInstance != null)
        {
            currentGodInstance.AddExperience(amount);
        }
    }

    public void SetCurrentGod(God god)
    {
        if (!godInstances.ContainsKey(god))
        {
            godInstances[god] = new GodInstance(god);
        }
        currentGodInstance = godInstances[god];
    }
}