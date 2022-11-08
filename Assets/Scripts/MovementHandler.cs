using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private float _speed = 20f;
    [SerializeField] private float _rotationSpeed = 50f;

    private void Update()
    {
        var verticalInput = Input.GetAxis("Vertical");
        var horizontalInput = Input.GetAxis("Horizontal");

        var step = Time.deltaTime * _speed;
        var rotationAngle = Time.deltaTime * _rotationSpeed;
        
        transform.Translate(Vector3.forward * step * verticalInput);
        transform.Rotate(Vector3.up, rotationAngle * horizontalInput);
    }
}
