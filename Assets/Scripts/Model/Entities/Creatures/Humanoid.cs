using System;
using UnityEngine;

namespace Model.Entities
{
    [CreateAssetMenu(fileName = "Entity", menuName = "ScriptableObjects/Entity")]
    public class Humanoid : Entity
    {
        [NonSerialized] public BodyPart Head;
        [NonSerialized] public BodyPart Chest;
        [NonSerialized] public BodyPart LeftArm;
        [NonSerialized] public BodyPart RightArm;
        [NonSerialized] public BodyPart LeftLeg;
        [NonSerialized] public BodyPart RightLeg;

        public override void InitializeBodyParts()
        {
            
        }
    }
}