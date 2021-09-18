using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MeleeWeapon : Weapon
{
    [Header("Melee Weapon Specific Attributes")]
    public MeleeWeaponType WeaponType = MeleeWeaponType.Axe;
}
