using UnityEngine;
using System.Collections;

public abstract class Ameba : MonoBehaviour
{

    [SerializeField]
    protected Transform p_target;

    public virtual void PerformBehaviour() { }

}
