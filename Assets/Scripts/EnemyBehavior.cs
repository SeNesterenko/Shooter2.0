using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    
    private Transform _target;

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private void Update()
    {
        var step = Time.deltaTime * _speed;
        transform.position = Vector3.MoveTowards(transform.position, _target.position, step);
        transform.LookAt(_target);
    }
}
