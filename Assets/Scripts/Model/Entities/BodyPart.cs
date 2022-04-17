using UnityEngine;

namespace Model.Entities
{
    public class BodyPart : MonoBehaviour
    {
        [SerializeField] private Entity creature;
        
        public float maxHealth;
        public float CurrentHealth { get; set; }

        public void TakeDamage()
        {
            
        }
    }
}