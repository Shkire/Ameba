using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AmebaTrigger : MonoBehaviour {

    private List<AmebaContainer> p_onEnter;
    private List<AmebaContainer> p_onExit;
    private List<AmebaContainer> p_onStay;

    public void AddOnEnter(AmebaContainer container)
    {
        if (p_onEnter == null)
            p_onEnter = new List<AmebaContainer>();
        p_onEnter.Add(container);
    }

    public void AddOnExit(AmebaContainer container)
    {
        if (p_onExit == null)
            p_onExit = new List<AmebaContainer>();
        p_onExit.Add(container);
    }

    public void AddOnStay(AmebaContainer container)
    {
        if (p_onStay == null)
            p_onStay = new List<AmebaContainer>();
        p_onStay.Add(container);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (p_onEnter == null)
            return;
        foreach (AmebaContainer container in p_onEnter)
            container.PerformBehaviours();
    }

    void OnTriggerExit(Collider collider)
    {
        if (p_onExit == null)
            return;
        foreach (AmebaContainer container in p_onExit)
            container.PerformBehaviours();
    }

    void OnTriggerStay(Collider collider)
    {
        if (p_onStay == null)
            return;
        foreach (AmebaContainer container in p_onStay)
            container.PerformBehaviours();
    }
}
