using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodDevotionManager : MonoBehaviour
{
    public List<God> gods;
    public God currentGod;
    public ExperienceManager experienceManager;

    void Start()
    {
        experienceManager = GetComponent<ExperienceManager>();
        DevoteToGod(currentGod);
    }

    public void DevoteToGod(God god)
    {
        currentGod = god;
        experienceManager.SetCurrentGod(god);
    }
}