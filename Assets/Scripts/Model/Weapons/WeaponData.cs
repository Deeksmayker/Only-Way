using System;
using UnityEngine;

namespace Model.Weapons
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "ScriptableObjects/Weapons")]
    public class WeaponData : ScriptableObject
    { 
        public string newName;
        public string description;
        public GameObject weaponPrefab;

        public float baseDamage;
    }
}