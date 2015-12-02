using UnityEngine;
using System.Collections;

public class AmebaController : MonoBehaviour
{

    public enum ActivationType
    {
        KeyPress,
        KeyRelease,
        Key,
        Timed,
        TriggerActivated,
        TriggerKeep,
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

    [SerializeField]
    private Collider p_collider;

    void Awake()
    {
        if (p_container == null)
            p_container = GetComponentInChildren<AmebaContainer>();

        if ((p_collider != null) && (p_collider.gameObject.GetComponent<AmebaTrigger>() == null))
        {
            p_collider.isTrigger = true;
            p_collider.gameObject.AddComponent<AmebaTrigger>();
            switch (p_activationCondition)
            {
                case ActivationType.TriggerActivated:
                    p_collider.gameObject.GetComponent<AmebaTrigger>().AddOnEnter(p_container);
                    break;
                case ActivationType.TriggerReleased:
                    p_collider.gameObject.GetComponent<AmebaTrigger>().AddOnExit(p_container);
                    break;
                case ActivationType.TriggerKeep:
                    p_collider.gameObject.GetComponent<AmebaTrigger>().AddOnStay(p_container);
                    break;
            }
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
