using UnityEngine;

public class Muzzle : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _bulletVelocity = 20f;

    private ScreenManager _screenManager;
    private int _countBullets;
    
    public void Initialize(ScreenManager screenManager, int countBullets)
    {
        _screenManager = screenManager;
        _countBullets = countBullets;
    }
    private void Update()
    {
        if (_countBullets <= 0)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(_bullet,transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;

            _countBullets -= 1;
            _screenManager.SetCountsBullets(_countBullets);
            
            bullet.SetManager(_screenManager);
        }
    }
}
