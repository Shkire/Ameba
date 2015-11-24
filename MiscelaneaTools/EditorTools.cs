using UnityEngine;
using System.Collections;
using UnityEditor;

public static class EditorTools : MonoBehaviour {

    public static void CutComponent(this Component comp) {
        ComponentClipboard.copied = comp;
        Destroy(comp);
    }

}
