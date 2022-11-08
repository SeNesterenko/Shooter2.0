using UnityEngine;

public class Muzzle : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _bulletVelocity = 20f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(_bullet,transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;
        }
    }
}
