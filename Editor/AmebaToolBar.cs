using UnityEngine;
using UnityEditor;

public class AmebaToolBar
{

    #region Button Definitions

    [MenuItem("Ameba/Control/AmebaController/Add")]
    private static void AddAmebaController()
    {
        GameObject sibling = Selection.activeGameObject;
        if (sibling != null)
            sibling.AddComponent<AmebaController>();
    }

    [MenuItem("Ameba/Control/AmebaController/New")]
    private static void NewAmebaController()
    {
        GameObject created = new GameObject("Ameba Controller");
        created.AddComponent<AmebaController>();
        GameObject sibling = Selection.activeGameObject;
        if (sibling != null)
            created.transform.SetParent(sibling.transform.parent);
    }

    [MenuItem("Ameba/Control/AmebaContainer/Add")]
    private static void AddAmebaContainer()
    {
        GameObject sibling = Selection.activeGameObject;
        if (sibling != null)
            sibling.AddComponent<AmebaContainer>();
    }

    [MenuItem("Ameba/Control/AmebaContainer/New")]
    private static void NewAmebaContainer()
    {
        GameObject created = new GameObject("Ameba Container");
        created.AddComponent<AmebaContainer>();
        GameObject sibling = Selection.activeGameObject;
        if (sibling != null)
            created.transform.SetParent(sibling.transform.parent);
    }

    [MenuItem("Ameba/Amebas/AmebaCreate")]
    private static void AddAmebaCreate()
    {
        Selection.activeGameObject.AddComponent<AmebaCreate>();
    }

    [MenuItem("Ameba/Amebas/AmebaDestroy")]
    private static void AddAmebaDestroy()
    {
        Selection.activeGameObject.AddComponent<AmebaDestroy>();
    }

    [MenuItem("Ameba/Amebas/AmebaMove")]
    private static void AddAmebaMove()
    {
        Selection.activeGameObject.AddComponent<AmebaMove>();
    }


    #endregion

    #region Button Validations

    [MenuItem("Ameba/Control/AmebaController/Add", true, 1)]
    private static bool AddAmebaControllerValidation()
    {
        return Selection.activeGameObject != null;
    }

    [MenuItem("Ameba/Control/AmebaController/New", true, 2)]
    private static bool NewAmebaControllerValidation()
    {
        return Selection.activeGameObject != null;
    }

    [MenuItem("Ameba/Control/AmebaContainer/Add", true, 1)]
    private static bool AddAmebaContainerValidation()
    {
        return Selection.activeGameObject != null;
    }

    [MenuItem("Ameba/Control/AmebaContainer/New", true, 2)]
    private static bool NewAmebaContainerValidation()
    {
        return Selection.activeGameObject != null;
    }

    [MenuItem("Ameba/Amebas/AmebaCreate", true, 1)]
    private static bool AddAmebaCreateValidation()
    {
        return Selection.activeGameObject != null && (Selection.activeGameObject.GetComponent<AmebaContainer>() != null || Selection.activeGameObject.GetComponentInParent<AmebaContainer>() != null);
    }

    [MenuItem("Ameba/Amebas/AmebaDestroy", true, 2)]
    private static bool AddAmebaDestroyValidation()
    {
        return Selection.activeGameObject != null && (Selection.activeGameObject.GetComponent<AmebaContainer>() != null || Selection.activeGameObject.GetComponentInParent<AmebaContainer>() != null);
    }

    [MenuItem("Ameba/Amebas/AmebaMove", true, 21)]
    private static bool AddAmebaMoveValidation()
    {
        return Selection.activeGameObject != null && (Selection.activeGameObject.GetComponent<AmebaContainer>() != null || Selection.activeGameObject.GetComponentInParent<AmebaContainer>() != null);
    }

    #endregion

}
