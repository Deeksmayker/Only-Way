namespace Model.Player.PlayerStateMachine
{
    public abstract class PlayerState
    {
        public abstract void EnterState(PlayerStateManager player);
        public abstract void UpdateState(PlayerStateManager player);
        public abstract void ExitState(PlayerStateManager player);
    }
}