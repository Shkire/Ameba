using UnityEngine;
using UnityEditor;

public class AmebaToolBar
{

    [MenuItem("Ameba/Behaviours/Add BehavioursManager", false, 1)]
    private static void AddBehavioursManager()
    {
        GameObject sibling = Selection.activeGameObject;
        if (sibling != null)
            sibling.AddComponent<BehavioursManager>();
    }

    [MenuItem("Ameba/Behaviours/New BehavioursManager", false, 2)]
    private static void NewBehavioursManager()
    {
        GameObject created = new GameObject("BehaviourManager");
        created.AddComponent<BehavioursManager>();
        GameObject sibling = Selection.activeGameObject;
        if (sibling != null)
            created.transform.SetParent(sibling.transform.parent);
    }

    [MenuItem("CONTEXT/Component/Cut component")]
    private static void CutComponent()
    {
        
    }

}
