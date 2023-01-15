using UnityEngine;


public class FindObjectsOfTypeMB : MonoBehaviour
{
    public GameObject FoundGO;
    public ObjectToFind FoundMB;
    private void Update()
    {
        FoundMB = FindObjectOfType<ObjectToFind>();
        FoundGO = FoundMB?.gameObject;
    }


}

