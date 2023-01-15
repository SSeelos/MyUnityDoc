using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MyMonoBehaviour))]
public class MyEditorScript : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var target = (MyMonoBehaviour)this.target;
        target.myProperty = 1;
        target.myProperty = EditorGUILayout.IntField("SetProperty", target.myProperty);
        EditorGUILayout.IntField("res", target.myProperty);

        if (GUILayout.Button("MyButton"))
        {
            target.SetField(1);
        }
    }
}