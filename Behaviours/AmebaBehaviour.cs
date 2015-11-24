using UnityEngine;
using System.Collections;

public class AmebaBehaviour : MonoBehaviour
{

    enum BehaviourType
    {
        Move,
        Destroy
    }

    [SerializeField]
    private BehaviourType _behaviour;

    [SerializeField]
    private Vector3 _movement;

    [SerializeField]
    private Transform _target;

    public void PerformBehaviour()
    {
        if (_behaviour == BehaviourType.Move)
        {
            _target.position += _movement;
        }
    }
}
