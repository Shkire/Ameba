using UnityEngine;
using System.Collections;

public class AmebaDestroy : Ameba
{

    public override void PerformBehaviour()
    {
        if (p_target == null)
            return;
        Destroy(p_target.gameObject);
    }

}
