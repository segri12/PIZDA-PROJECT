using UnityEngine;

public class SpawnerPoints : MonoBehaviour
{
    [SerializeField] private Vector3 _position; 
    [SerializeField] private Enemy _enemyPrefab; 
    [SerializeField] private Target _target;

    public void Spawn()
    {
        Enemy copy = Instantiate(_enemyPrefab, _position, Quaternion.identity);
        copy.SetTarget(_target);
    }
}