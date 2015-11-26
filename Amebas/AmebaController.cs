using UnityEngine;
using System.Collections;

public class AmebaController : MonoBehaviour
{

    enum ActivationType
    {
        KeyPress,
        KeyRelease,
        Key,
        Timed,
        TriggerActivated,
        TriggerReleased,
        CollisionEnter,
        CollisionExit,
        DuringCollision
    }

    [SerializeField]
    private ActivationType _activationCondition;

    [SerializeField]
    private string _key;

    [SerializeField]
    private Transform _target;

    // Update is called once per frame
    void Update()
    {
        if (_activationCondition == ActivationType.KeyPress)
        {
            if (Input.GetKeyDown(_key))
            {
                foreach (Ameba behaviour in GetComponentsInChildren<Ameba>())
                {
                    behaviour.PerformBehaviour();
                }
            }
        }
    }
}
