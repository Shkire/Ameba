using UnityEngine;
using UnityEditor;

public class AmebaToolBar
{

    [MenuItem("Ameba/Control/Add AmebaController", false, 1)]
    private static void AddBehavioursManager()
    {
        GameObject sibling = Selection.activeGameObject;
        if (sibling != null)
            sibling.AddComponent<AmebaController>();
    }

    [MenuItem("Ameba/Control/New AmebaController", false, 2)]
    private static void NewBehavioursManager()
    {
        GameObject created = new GameObject("BehaviourManager");
        created.AddComponent<AmebaController>();
        GameObject sibling = Selection.activeGameObject;
        if (sibling != null)
            created.transform.SetParent(sibling.transform.parent);
    }

    [MenuItem("Ameba/Amebas/AmebaCreate", false, 1)]
    private static void AmebaCreate()
    {
    }

    [MenuItem("Ameba/Amebas/AmebaDestroy", false, 2)]
    private static void AmebaDestroy()
    {
    }

    [MenuItem("Ameba/Amebas/AmebaMove", false, 21)]
    private static void AmebaMove()
    {
    }

}
