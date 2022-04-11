using Control;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity;
    [SerializeField] private float maxVerticalRotation = 90f;
    [SerializeField] private Transform playerBody;
    private float _xRotation;
    
    private void Update()
    {
        /*var mouseX = InputManager.MouseX * mouseSensitivity * Time.deltaTime;
        var mouseY = InputManager.MouseY * mouseSensitivity * Time.deltaTime;*/

        /*_xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -maxVerticalRotation, maxVerticalRotation);
        
        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);*/
    }
}
