using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class FindObject : MonoBehaviour
{
    public GameObject FoundObject;

    [SerializeField]
    List<ObjectToFind> prefabs;

    [SerializeField]
    List<ObjectToFind> prefabsFound;

    [SerializeField]
    List<ObjectToFind> prefabsStored;

    [SerializeField]
    GameObject[] prefabsTagged;

    private void Awake()
    {
        //very slow function call! dont use in a game loop!
        prefabsFound = FindObjectsOfType<ObjectToFind>().ToList();

        //very slow function call! dont use in a game loop! (but faster than ofType)
        prefabsTagged = GameObject.FindGameObjectsWithTag("MyTag");

        //far better way to find object (stored in a data container)
        prefabsStored = ObjectToFind.AllObjectsToFind;

    }
    private void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            ToggleObject();
        }
    }
    private void ToggleObject()
    {
        foreach (var prefab in prefabs)
        {
            var gObject = prefab.gameObject;
            if (gObject.activeSelf)
                gObject.SetActive(false);
            else
                gObject.SetActive(true);

        }
    }
}

