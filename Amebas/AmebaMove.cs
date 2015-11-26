using UnityEngine;
using System.Collections;

public class AmebaMove : Ameba{

    [SerializeField]
    private Vector3 _movement;

    public override void PerformBehaviour()
    {
            _target.position += _movement;
    }
}
