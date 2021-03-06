using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Control
{
    public class GameInputManager : MonoBehaviour
    {
	    [Header("Character Input Values")]
        public Vector2 move;
        public Vector2 look;
        public bool jump;
        public bool sprint;
        public bool rightAttack;
        public bool leftAttack;

        [Header("Mouse Cursor Settings")]
        public bool cursorLocked = true;
        public bool cursorInputForLook = true;
        
        public void OnMove(InputValue value)
		{
			MoveInput(value.Get<Vector2>());
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				LookInput(value.Get<Vector2>());
			}
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}

		public void OnRightAttack(InputValue value)
		{
			RightAttackInput(value.isPressed);
		}

		public void OnLeftAttack(InputValue value)
		{
			LeftAttackInput(value.isPressed);
		}

		public void MoveInput(Vector2 newMoveDirection)
        {
            move = newMoveDirection;
        } 

        public void LookInput(Vector2 newLookDirection)
        {
            look = newLookDirection;
        }

        public void JumpInput(bool newJumpState)
        {
            jump = newJumpState;
        }

        public void SprintInput(bool newSprintState)
        {
            sprint = newSprintState;
        }

        public void RightAttackInput(bool newAttackState)
        {
	        rightAttack = newAttackState;
        }

        public void LeftAttackInput(bool newAttackState)
        {
	        leftAttack = newAttackState;
        }

        /*public void CheckJumpInputs()
        {
            if (_playerControls.Jump.WasPressedThisFrame())
                OnJumpButtonDown.Invoke();
            if (_playerControls.Jump.WasReleasedThisFrame())
                OnJumpButtonUp.Invoke();
        }*/
    }
}