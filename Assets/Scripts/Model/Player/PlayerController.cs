using System.Collections;
using System.Collections.Generic;
using Control;
using Model.Player;
using UnityEngine;

public class PlayerController : PlayerPhysics
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpHeight;
    
    [SerializeField] private Transform cameraTransform;
    private float previousCameraYRotation;
    private Transform _body;
    private InputManager _inputManager;

    private void Awake()
    {
        _inputManager = InputManager.Instance;
        _body = transform;
        InputManager.OnJumpButtonDown.AddListener(Jump);
    }
    
    protected override void FixedUpdate()
    {
        Move();
        //RotatePlayerByCamera();
        base.FixedUpdate();
    }

    private void Move()
    {
        var movement = _inputManager.GetPlayerMovement();
        var move = cameraTransform.right * movement.x + cameraTransform.forward * movement.y;

        CharacterController.Move(move * speed * Time.deltaTime);
    }

    private void RotatePlayerByCamera()
    {
        if (previousCameraYRotation.Equals(cameraTransform.rotation.y * 180))
            return;
        
        _body.Rotate(Vector3.up * (cameraTransform.rotation.y * 180 - previousCameraYRotation));
        previousCameraYRotation = cameraTransform.rotation.y * 180;
    }

    private void Jump()
    {
        if (!PlayerPreferences.Grounded)
            return;
        Velocity.y += Mathf.Sqrt(jumpHeight * -2f * Gravity);
    }
}
