using UnityEngine;

namespace Model.Player.PlayerStateMachine
{
    public class PlayerFightState : PlayerState
    {
        private float _attackDuration = 0.5f;
        private float _currentAttackDuration;
        
        public override void EnterState(PlayerStateManager player)
        {
            
        }
        
        public override void UpdateState(PlayerStateManager player)
        {
            if (player.PlayerInput.rightAttack && _currentAttackDuration <= 0)
            {
                player.weapon.GetComponent<BoxCollider>().enabled = true;
                _currentAttackDuration = _attackDuration;
                player.animator.SetBool("FastAttack", true);
                player.PlayerInput.rightAttack = false;
            }

            if (_currentAttackDuration >= 0)
            {
                _currentAttackDuration -= Time.deltaTime;
                if (_currentAttackDuration <= 0)
                {
                    player.weapon.GetComponent<BoxCollider>().enabled = false;
                    player.animator.SetBool("FastAttack", false);
                }
            }
            
        }
        
        public override void ExitState(PlayerStateManager player)
        {
            
        }
    }
}