using UnityEngine;
using System.Collections;

public class AmebaMove : Ameba
{

    [SerializeField]
    private Vector3 p_movement;

    public override void PerformBehaviour(float duration)
    {
        if (p_target == null)
            return;
        p_target.position += p_movement;
    }
}
