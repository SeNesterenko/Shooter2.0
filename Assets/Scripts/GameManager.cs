using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private int _enemiesCount;
    [SerializeField] private int _spawnRadius;

    [SerializeField] private ScreenManager _screenManager;

    [SerializeField] private Muzzle _weapon;
    [SerializeField] private Bullet _bullet;
    [SerializeField] private int _countBullets;
    

    private void Awake()
    {
        _enemySpawner.Initialize(_enemiesCount, _spawnRadius, _player);
        _screenManager.Initialize(_enemiesCount, _countBullets);
        _weapon.Initialize(_screenManager, _countBullets);
    }
}
