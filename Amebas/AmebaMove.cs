using UnityEngine;
using System.Collections;

public class AmebaMove : Ameba
{

    [SerializeField]
    private Vector3 _movement;

    public override void PerformBehaviour()
    {
        if (p_target == null)
            return;
        p_target.position += _movement;
    }
}
