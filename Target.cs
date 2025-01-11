using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField, Min(0)] private float _speed;

    private int _currentWaypointIndex = 0;

    private void Update()
    {
        if (_waypoints.Length == 0) return;

        Transform targetWaypoint = _waypoints[_currentWaypointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, _speed * Time.deltaTime);

        if (transform.position == targetWaypoint.position)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Length;
        }
    }
}