
using System.Collections.Generic;
using UnityEngine;

public class ObjectToFind : MonoBehaviour
{
    private FindObject findObject;
    //readonly is not nessesary
    //but enforces this to not be recreated or destroyed
    public static readonly List<ObjectToFind> AllObjectsToFind = new List<ObjectToFind>();

    private void OnEnable() => AllObjectsToFind.Add(this);
    private void OnDisable() => AllObjectsToFind.Remove(this);

    public void Init(FindObject findObject)
    {
        this.findObject = findObject;
        findObject.FoundObject = this.gameObject;
    }
}