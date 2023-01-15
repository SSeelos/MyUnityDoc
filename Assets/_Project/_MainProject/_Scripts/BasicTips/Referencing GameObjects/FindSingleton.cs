using UnityEngine;

public class FindSingleton : MonoBehaviour
{
    public MySingletonMB FoundSingletonMB;
    public GameObject FoundSingletonGO;

    private void Update()
    {
        FoundSingletonMB = MySingletonMB.I;
        FoundSingletonGO = MySingletonMB.I?.gameObject;
    }
}
