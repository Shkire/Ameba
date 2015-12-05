using UnityEngine;
using System.Collections;

public class AmebaDestroy : Ameba
{

    public override void PerformBehaviour(float duration)
    {
        if (p_target == null)
            return;
        Destroy(p_target.gameObject);
    }

}
