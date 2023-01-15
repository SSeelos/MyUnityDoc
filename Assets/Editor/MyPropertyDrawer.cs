using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(MySerializableClass))]
public class MyPropertyDrawer : PropertyDrawer
{
    // Draw the property inside the given rect
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Using BeginProperty / EndProperty on the parent property means that
        // prefab override logic works on the entire property.
        EditorGUI.BeginProperty(position, label, property);

        // Draw label
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        // Don't make child fields be indented
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Calculate rects
        var nameRect = new Rect()
        {
            x = position.x,
            y = position.y,
            width = position.width / 2,
            height = position.height / 2
        };

        var enumRect = new Rect()
        {
            x = position.x + position.width / 2,
            y = position.y,
            width = position.width / 2,
            height = position.height / 2
        };


        // Draw fields - pass GUIContent.none to each so they are drawn without labels
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("Name"), GUIContent.none);
        EditorGUI.PropertyField(enumRect, property.FindPropertyRelative("MyEnum"), GUIContent.none);

        //default drawing
        EditorGUI.PropertyField(position, property);
        // Set indent back to what it was
        EditorGUI.indentLevel = indent;

        var helpBox = new Rect()
        {
            x = position.min.x,
            y = position.min.y + position.height / 2,
            width = position.width,
            height = position.height / 2
        };

        //EditorGUI.HelpBox(helpBox, "MyHelpBox", MessageType.Info);

        EditorGUI.EndProperty();
    }
}
