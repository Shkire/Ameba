using UnityEngine;
using System.Collections;

public abstract class Ameba : MonoBehaviour
{

    [SerializeField]
    protected Transform _target;

    public virtual void PerformBehaviour() { }

}
