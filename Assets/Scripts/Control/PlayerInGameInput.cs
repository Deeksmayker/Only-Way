using System;
using UnityEngine;
using UnityEngine.Events;

namespace Control
{
    public class PlayerInGameInput : MonoBehaviour
    {
        public static KeyCode JumpButton = KeyCode.Space;
        
        public static float HorizontalAxis;
        public static float VerticalAxis;

        public static float MouseX;
        public static float MouseY;

        public static UnityEvent OnJumpButtonDown = new UnityEvent();
        
        private void Update()
        {
            CheckAxisInput();
            CheckMouseInput();
            CheckJumpInput();
        }

        private void CheckAxisInput()
        {
            HorizontalAxis = Input.GetAxis("Horizontal");
            VerticalAxis = Input.GetAxis("Vertical");
        }

        private void CheckMouseInput()
        {
            MouseX = Input.GetAxis("Mouse X");
            MouseY = Input.GetAxis("Mouse Y");
        }

        private void CheckJumpInput()
        {
            if (Input.GetKeyDown(JumpButton))
            {
                OnJumpButtonDown.Invoke();
            }
        }
    }
}