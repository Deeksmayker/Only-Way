using System;
using Model.Entities;
using UnityEngine;

namespace Model.Weapons
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private WeaponData weaponData;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<BodyPart>() == null)
                return;
            
            other.gameObject.GetComponent<BodyPart>().TakeDamage();
        }
    }
}