
using System.IO;
using UnityEditor;
using UnityEngine;

public static class MenuItemFuntions
{
    [MenuItem(MenuItemConstants.MyMenuItems + "/MyMenuItem")]
    public static void MyMenuItemFct()
    {
        Debug.Log("MyMenuItem: Hello");
    }
    [MenuItem(MenuItemConstants.MyMenuItems_Tools + "/Create Default Folders")]
    public static void CreateDefaultFolders()
    {
        CreateDirectories("_Project");
        AssetDatabase.Refresh();
    }
    public static void CreateDirectories(string root, params string[] directies)
    {
        var fullPath = Path.Combine(Application.dataPath, root);
        foreach (var dir in directies)
        {
            Directory.CreateDirectory(Path.Combine(fullPath, dir));
        }
    }
}

