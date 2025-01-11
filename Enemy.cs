using UnityEngine;

public class Enemy : MonoBehaviour  
{
    [SerializeField] private Mover _mover;
   
    public void SetTarget(Target target)
    {
        _mover.SetTarget(target);
    }
}