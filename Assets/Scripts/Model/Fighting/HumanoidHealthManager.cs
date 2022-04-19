using Model.Entities;
using UnityEngine;

namespace Model.Fighting
{
    public class HumanoidHealthManager : MonoBehaviour
    {
        [SerializeField] private HumanoidData humanoidData;
        [SerializeField] private ParticleSystem takeDamageParticle;

        private void Awake()
        {
            humanoidData.InitializeBodyParts();
        }
        
        public void TakeDamage(GameObject bodyPart)
        {
            Instantiate(takeDamageParticle, bodyPart.transform);
        }
    }
}