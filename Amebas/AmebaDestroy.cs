using UnityEngine;
using System.Collections;

public class AmebaDestroy : Ameba {

    public override void PerformBehaviour()
    {
        Destroy(_target.gameObject);
    }
	
}
