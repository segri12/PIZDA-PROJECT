using UnityEngine;

public class Enemy : MonoBehaviour   343434
{
    [SerializeField] private Mover _mover;
   
    public void SetTarget(Target target)
    {
        _mover.SetTarget(target);
    }
}