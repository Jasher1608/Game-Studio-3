using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStatUtils
{
    public static float CalculateMaxHealth(Stats stats)
    {
        float maxHealth = stats.GetStat(Stat.maxHealth) * stats.GetStat(Stat.maxHealthModifier);
        return maxHealth;
    }
    public static float CalculateMeleeDamage(Stats stats)
    {
        float meleeDamage = stats.GetStat(Stat.meleeDamage) * stats.GetStat(Stat.meleeDamageModifier);
        return meleeDamage;
    }
    public static float CalculateMeleeRange(Stats stats)
    {
        float meleeRange = stats.GetStat(Stat.meleeRange) * stats.GetStat(Stat.meleeRangeModifier);
        return meleeRange;
    }
    public static float CalculateMeleeCooldown(Stats stats)
    {
        float meleeCooldown = stats.GetStat(Stat.meleeCooldown) * stats.GetStat(Stat.meleeCooldownModifier);
        return meleeCooldown;
    }
    public static float CalculateArmour(Stats stats)
    {
        float armour = stats.GetStat(Stat.armour) * stats.GetStat(Stat.armourModifier);
        return armour;
    }
    public static float CalculateMana(Stats stats)
    {
        float mana = stats.GetStat(Stat.mana) * stats.GetStat(Stat.manaModifier);
        return mana;
    }
    public static float CalculateMagicDamage(Stats stats)
    {
        float magicDamage = stats.GetStat(Stat.magicDamage) * stats.GetStat(Stat.magicDamageModifier);
        return magicDamage;
    }
    public static float CalculateMagicRange(Stats stats)
    {
        float magicRange = stats.GetStat(Stat.magicRange) * stats.GetStat(Stat.magicRangeModifier);
        return magicRange;
    }
    public static float CalculateMagicCooldown(Stats stats)
    {
        float magicCooldown = stats.GetStat(Stat.magicCooldown) * stats.GetStat(Stat.magicCooldownModifier);
        return magicCooldown;
    }
    public static float CalculateLuck(Stats stats)
    {
        float luck = stats.GetStat(Stat.luck) * stats.GetStat(Stat.luckModifier);
        return luck;
    }
    public static float CalculateMovementSpeed(Stats stats)
    {
        float movementSpeed = stats.GetStat(Stat.movementSpeed) * stats.GetStat(Stat.movementSpeedModifier);
        return movementSpeed;
    }
    public static float CalculateDashRange(Stats stats)
    {
        float dashRange = stats.GetStat(Stat.dashRange) * stats.GetStat(Stat.dashRangeModifier);
        return dashRange;
    }
    public static float CalculateDashCooldown(Stats stats)
    {
        float dashCooldown = stats.GetStat(Stat.dashCooldown) * stats.GetStat(Stat.dashCooldownModifier);
        return dashCooldown;
    }
    public static float CalculateCritChance(Stats stats)
    {
        float critChance = stats.GetStat(Stat.critChance) * stats.GetStat(Stat.critChanceModifier);
        return critChance;
    }
    public static float CalculateCritDamage(Stats stats)
    {
        float critDamage = stats.GetStat(Stat.critDamage) * stats.GetStat(Stat.critDamageModifier);
        return critDamage;
    }
}