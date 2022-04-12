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
    private GameInputManager _gameInputManager;

    private void Awake()
    {
        _gameInputManager = GameInputManager.Instance;
        _body = transform;
        GameInputManager.OnJumpButtonDown.AddListener(Jump);
    }
    
    protected override void FixedUpdate()
    {
        Move();
        
        base.FixedUpdate();
    }

    private void Move()
    {
        var movement = _gameInputManager.GetPlayerMovement();
        var move = cameraTransform.right * movement.x + cameraTransform.forward * movement.y;
        move.y = 0;
        CharacterController.Move(move * speed * Time.deltaTime);
    } 
    

    private void Jump()
    {
        if (!PlayerPreferences.Grounded)
            return;
        VerticalVelocity.y += Mathf.Sqrt(jumpHeight * -2f * Gravity);
    }
}
