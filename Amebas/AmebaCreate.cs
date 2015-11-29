using UnityEngine;
using System.Collections;

public class AmebaCreate : Ameba
{

    [SerializeField]
    private GameObject p_model;

    [SerializeField]
    private bool p_targetRotation;

    public override void PerformBehaviour()
    {
        if (p_target == null || p_model == null)
            return;
        if (p_targetRotation)
            Instantiate(p_model, p_target.position, p_target.rotation);
        else
            Instantiate(p_model, p_target.position, p_model.transform.rotation);
    }

}
