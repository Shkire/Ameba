using UnityEngine;
using System.Collections;

public class AmebaTimer : MonoBehaviour {

    [SerializeField]
    private float p_startTime;
    [SerializeField]
    private float p_duration;

    public float startTime
    {
        get
        {
            return p_startTime;
        }
    }

}
