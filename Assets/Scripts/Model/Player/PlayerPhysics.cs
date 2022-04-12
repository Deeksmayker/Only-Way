using System;
using UnityEngine;

namespace Model.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class PlayerPhysics : MonoBehaviour
    {
        private Collider[] _colliders = new Collider[10];

        [SerializeField] private float gravityMultiplayer;
        protected float Gravity = -9.81f;
        protected CharacterController CharacterController;
        protected Vector3 VerticalVelocity;

        [SerializeField] private Transform groundChecker;
        [SerializeField] private float groundDistance;
        

        private void Start()
        {
            Gravity *= gravityMultiplayer;
            CharacterController = GetComponent<CharacterController>();
        }

        protected virtual void FixedUpdate()
        {
            MakeGravity();
        }

        private void MakeGravity()
        {
            CheckGround();
            VerticalVelocity += transform.up * Gravity * Time.deltaTime;

            CharacterController.Move(VerticalVelocity * Time.deltaTime);
        }

        private void CheckGround()
        {
            PlayerPreferences.Grounded = Physics.OverlapSphereNonAlloc(groundChecker.position, groundDistance, _colliders) > 0;

            if (PlayerPreferences.Grounded && VerticalVelocity.y < 0)
            {
                VerticalVelocity.y = -2f;
            }
        }
    }
}