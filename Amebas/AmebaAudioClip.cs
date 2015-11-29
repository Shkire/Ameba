using UnityEngine;
using System.Collections;

public class AmebaAudioClip : Ameba {

    [SerializeField]
    private AudioClip p_clip;

    [SerializeField]
    private bool p_onLoop;

    [SerializeField]
    private bool p_forceOneShot;

    public override void PerformBehaviour() 
    {
        if (p_target == null)
            return;
        GameObject newTarget = p_target.gameObject;
        if (p_forceOneShot)
        {
            newTarget = new GameObject("One Shot Audio");
            newTarget.transform.SetTransform(p_target);
        }
        if (newTarget.gameObject.GetComponent<AudioSource>() == null)
            newTarget.AddComponent<AudioSource>();
        newTarget.GetComponent<AudioSource>().Config(p_clip, p_onLoop);
    }

}
