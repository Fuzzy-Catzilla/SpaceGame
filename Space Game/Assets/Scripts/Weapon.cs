using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : ScriptableObject
{
    [Header("General Attributes")]
    public string Name = "Insert Name";
    public Image Icon;
    public Rarity WeaponRarity = Rarity.Common;
    public float Damage;
    public float Weight = 0.0f;
    public int StrengthRequirement = 0;
    public int DexterityRequirement = 0;
    public int FocusRequirement = 0;
}
