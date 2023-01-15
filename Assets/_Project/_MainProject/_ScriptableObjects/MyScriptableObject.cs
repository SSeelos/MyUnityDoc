using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = AssetMenuConstants.MenuName.ScriptableObject + "/MyScriptableObject")]
public class MyScriptableObject : ScriptableObject
{
    [Header("MyHeader")]

    [Tooltip("MyTooltip")]
    public string data;

    [Min(0), Tooltip("Def min value")]
    public int myMin;

    [Range(0, 99), Tooltip("Def min, max")]
    public int myRange;

    [Multiline(2)]
    public string myMultiline;

    //serialize reference
    //-> list can hold reference to different derived types
    //(not just the base type)
    [SerializeReference]
    public List<MySerializableClass> mySerializableClasses;

    [ContextMenu("MyContextMenuCommand")]
    public void CtxMenuFct()
    {
        Debug.Log("MyContextMenuCommand: Hi!");
    }

    //not working?
    [ContextMenuItem("MyContextMenuItem", nameof(CtxMenuItemFct))]
    public int ItemData = 1;
    void CtxMenuItemFct()
    {
        Debug.Log("MyContextMenuCommand: Hi! " + ItemData);

    }

#if UNITY_EDITOR
    private void OnValidate()
    {

    }

    [MenuItem(MenuItemConstants.MyMenuItems + "/CreateMyScriptableObject")]
    public static void CreateMyScriptableObject()
    {
        var mySO = CreateInstance<MyScriptableObject>();
        mySO.name = "MySO Name";

        var targetDir = "Assets/Resources/ScriptableObjects";
        if (!AssetDatabase.IsValidFolder("Assets/Resources"))
            AssetDatabase.CreateFolder("Assets", "Resources");
        if (!AssetDatabase.IsValidFolder(targetDir))
            AssetDatabase.CreateFolder("Assets/Resources", "ScriptableObjects");

        AssetDatabase.CreateAsset(mySO, $"{targetDir}/{mySO.name}.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = mySO;
    }
#endif

    #region ScriptableObject Lifecycle

    private void Awake()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());
    }
    private void OnEnable()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

    }
    private void OnDisable()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

    }
    private void OnDestroy()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

    }

    #endregion
}
