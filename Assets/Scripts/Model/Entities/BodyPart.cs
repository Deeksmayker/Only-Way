using System;
using Model.Fighting;
using UnityEngine;

namespace Model.Entities
{
    public class BodyPart : MonoBehaviour
    {
        private HumanoidHealthManager creature;
        
        public float maxHealth;
        public float CurrentHealth { get; set; }

        private void Awake()
        {
            creature = GetComponentInParent<HumanoidHealthManager>();
        }

        public void TakeDamage()
        {
            creature.TakeDamage(gameObject);
        }
    }
}