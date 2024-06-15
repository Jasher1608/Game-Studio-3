using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
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
        currentGodInstance = new GodInstance(god);
    }
}