//Doesnt actually work?? but this is from the documentation...


//using UnityEditor;
//using UnityEditor.UIElements;
//using UnityEngine.UIElements;
///// <summary>
///// Use this to create custom drawers for your own Serializable classes 
///// or for script variables with custom PropertyAttributes.

/////Uses:
///// Customize the GUI of every instance of a Serializable class.
///// Customize the GUI of script members with custom PropertyAttributes.
///// </summary>
//[CustomPropertyDrawer(typeof(MySerializableClass))]
//public class MyPropertyDrawer_UIElement : PropertyDrawer
//{
//    public override VisualElement CreatePropertyGUI(SerializedProperty property)
//    {
//        // Create property container element.
//        var visualElem = new VisualElement();

//        // Create property fields.
//        var nameField = new PropertyField(property.FindPropertyRelative("name"), "My PropertyField Label name");
//        var enumField = new PropertyField(property.FindPropertyRelative("MyEnum"), "My PropertyField Label for MyEnum");

//        // Add fields to the container.
//        visualElem.Add(nameField);
//        visualElem.Add(enumField);

//        return visualElem;
//    }
//}
