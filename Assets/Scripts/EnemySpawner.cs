using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyBehavior _enemy;
    
    private int _enemiesCount = 5;
    private int _spawnRadius = 50;
    private Transform _target;

    public void Initialize(int enemiesCount, int spawnRadius, Transform target)
    {
        _enemiesCount = enemiesCount;
        _spawnRadius = spawnRadius;
        _target = target;
    }

    private void Start()
    {
        for (var i = 0; i < _enemiesCount; i++)
        {
            var enemy = Instantiate(_enemy);
            SetEnemyPosition(enemy);
            enemy.SetTarget(_target);
        }
    }

    private void SetEnemyPosition(EnemyBehavior enemy)
    {
        var randomPosition = Random.insideUnitCircle * _spawnRadius;
        var enemyPosition = enemy.transform.position;

        enemyPosition.x += randomPosition.x;
        enemyPosition.z += randomPosition.y;

        enemy.transform.position = enemyPosition;
    }
    
}
