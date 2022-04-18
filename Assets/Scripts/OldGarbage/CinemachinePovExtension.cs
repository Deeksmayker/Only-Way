/*using UnityEngine;
using Cinemachine;
using Control;

namespace Model.Player
{
    public class CinemachinePovExtension : CinemachineExtension
    {
        [SerializeField] private float sensitivity;
        [SerializeField] private float clampAngle;
        [SerializeField] private Transform playerBody;
        
        private Vector3 _startingRotation;
        private GameInputManager _gameInputManager;

        protected override void Awake()
        {
            _gameInputManager = GameInputManager.Instance;
            Application.targetFrameRate = 200;
            base.Awake();
        }
        
        protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam,
            CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
        {
            if (vcam.Follow)
            {
                if (stage == CinemachineCore.Stage.Aim)
                {
                    var deltaInput = _gameInputManager.GetMouseDelta();
                    
                    _startingRotation.x += deltaInput.x * sensitivity * Time.deltaTime;
                    _startingRotation.y += deltaInput.y * sensitivity * Time.deltaTime;
                    _startingRotation.y = Mathf.Clamp(_startingRotation.y, -clampAngle, clampAngle);
                    
                    state.RawOrientation = Quaternion.Euler(-_startingRotation.y, _startingRotation.x, 0f);
                    playerBody.Rotate(Vector3.up * deltaInput.x * sensitivity * Time.deltaTime);
                }
            }
        }
    }
}*/