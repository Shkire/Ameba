using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AmebaTimer))]
public abstract class Ameba : MonoBehaviour
{

    [SerializeField]
    protected Transform p_target;

    public virtual void PerformBehaviour() { }

}
