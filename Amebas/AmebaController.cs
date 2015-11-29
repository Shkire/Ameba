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
    private AmebaContainer p_container;

    [SerializeField]
    private ActivationType p_activationCondition;

    [SerializeField]
    private string p_key;

    [SerializeField]
    private Transform p_target;

    void Awake()
    {
        if (p_container == null)
        {
            p_container = GetComponentInChildren<AmebaContainer>();
        }
    }

    void Update()
    {
        if (p_container == null)
            return;

        if (p_activationCondition == ActivationType.KeyPress)
        {
            if (Input.GetKeyDown(p_key))
            {
                p_container.PerformBehaviours();
            }
        }
    }
}
