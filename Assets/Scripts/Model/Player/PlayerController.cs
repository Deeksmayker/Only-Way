using System.Collections;
using System.Collections.Generic;
using Control;
using Model.Player;
using UnityEngine;

public class PlayerController : PlayerPhysics
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpHeight;

    private Transform _body;

    private void Awake()
    {
        _body = transform;
        PlayerInGameInput.OnJumpButtonDown.AddListener(Jump);
    }
    
    protected override void FixedUpdate()
    {
        Move();
        base.FixedUpdate();
    }

    private void Move()
    {
        var move = _body.right * PlayerInGameInput.HorizontalAxis + _body.forward * PlayerInGameInput.VerticalAxis;
        
        CharacterController.Move(move * speed * Time.deltaTime);
    }

    private void Jump()
    {
        if (!PlayerPreferences.Grounded)
            return;
        Velocity.y += Mathf.Sqrt(jumpHeight * -2f * Gravity);
    }
}
