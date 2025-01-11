using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField, Min(0)] private float _speed;
    private Transform _target;
    
    public void SetTarget(Target target)
    {
        _target = target.transform;
    }

    private void Update()
    {
        if (_target != null)
        {
            Vector3 direction = (_target.position - transform.position).normalized;
            transform.position += direction * _speed * Time.deltaTime;
        }
    }
}