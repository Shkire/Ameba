using UnityEngine;
using System.Collections;

public static class ExtensionTools{

    public static void SetTransform(this Transform trans1, Transform trans2)
    {
        trans1.position = trans2.position;
        trans1.rotation = trans2.rotation;
        trans1.localScale = trans2.localScale;
    }

    public static void Config(this AudioSource audioSource, AudioClip clip, bool loop) 
    {
        audioSource.enabled = false;
        audioSource.clip = clip;
        audioSource.loop = loop;
        audioSource.enabled = true;
    }

}
