using UnityEngine;
using System.Collections;

public class BehavioursManager : MonoBehaviour
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
                foreach (AmebaBehaviour behaviour in GetComponentsInChildren<AmebaBehaviour>())
                {
                    behaviour.PerformBehaviour();
                }
            }
        }
    }
}
