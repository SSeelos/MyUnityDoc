public enum MyEnum
{
    enumA,
    enumB,
}
[System.Serializable]
public class MySerializableClass
{
    public string Name;
    public MyEnum MyEnum;
}

[System.Serializable]
public class MyDerivedSerializableClass : MySerializableClass
{
    public string Description;
}
