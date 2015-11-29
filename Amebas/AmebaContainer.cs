using UnityEngine;
using System.Collections;

public class AmebaContainer : MonoBehaviour
{

    private Ameba[] p_amebaList;

    void Awake()
    {
        p_amebaList = GetComponents<Ameba>();
        if (p_amebaList != null)
            return;
        p_amebaList = GetComponentsInChildren<Ameba>();
    }

    public void PerformBehaviours()
    {
        foreach (Ameba ameba in p_amebaList)
        {
            ameba.PerformBehaviour();
        }
    }
}
