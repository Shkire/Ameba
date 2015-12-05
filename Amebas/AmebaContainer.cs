using UnityEngine;
using System.Collections;

public class AmebaContainer : MonoBehaviour
{
    public void PerformBehaviours()
    {
        AmebaTimer[] timers = GetComponentsInChildren<AmebaTimer>();
        foreach (AmebaTimer timer in timers)
            StartCoroutine(ThrowAmebas(timer));
    }

    IEnumerator ThrowAmebas(AmebaTimer timer)
    {
        yield return new WaitForSeconds(timer.startTime);
        foreach (Ameba ameba in timer.gameObject.GetComponents<Ameba>())
            ameba.PerformBehaviour(timer.duration);
    }
}
