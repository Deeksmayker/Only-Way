using UnityEngine;

namespace Model.Entities
{
    public abstract class Entity : ScriptableObject
    {
        public string newName;
        public GameObject model;
    
        public float maxBlood = 100;
        private float _currentBlood = 100;
        public float CurrentBlood { get => _currentBlood; set => _currentBlood = value; }

        public bool dangerous;

        public abstract void InitializeBodyParts();
    }
}