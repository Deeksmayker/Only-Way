using System;
using UnityEngine;

namespace Model.Entities
{
    [CreateAssetMenu(fileName = "Humanoid", menuName = "ScriptableObjects/Entity")]
    public class HumanoidData : Entity
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