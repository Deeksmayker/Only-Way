using System.Collections;
using System.Collections.Generic;
using Control;
using Model.Player;
using UnityEngine;

public class PlayerController : PlayerPhysics
{
    public float speed;
    public float jumpHeight;
    
    [SerializeField] private Transform cameraTransform;

    private GameInputManager _gameInputManager;

    private void Awake()
    {
        _gameInputManager = GameInputManager.Instance;
        GameInputManager.OnJumpButtonDown.AddListener(Jump);
    }
    
    protected override void FixedUpdate()
    {
        Move();
        
        base.FixedUpdate();
    }

    private void Move()
    {

        var movement = _gameInputManager.GetPlayerMovementRaw();
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
