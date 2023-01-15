using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqFinder : MonoBehaviour
{
    private ObjectToFind[] allObjs;
    public ObjectToFind nearestObj;

    public int nObjs;
    public List<ObjectToFind> nearestNObjs;

    private void Awake()
    {
        allObjs = FindObjectsOfType<ObjectToFind>();
    }
    private void OnEnable()
    {
        Find();
    }

    private void Find()
    {
        nearestObj = FindNearestObj();

        nearestNObjs = FindNearestNObjects(nObjs);
    }

    private void FixedUpdate()
    {
        Find();
        // nearestObj = FindNearestObj(); NOT recommended!
    }

    private ObjectToFind FindNearestObj()
    {
        return allObjs
            .OrderBy(t => transform.position.Distance(t.transform.position))
            .FirstOrDefault();
    }
    private List<ObjectToFind> FindNearestNObjects(int n)
    {
        return allObjs
            .OrderBy(t => transform.position.Distance(t.transform.position))
            .Take(n)
            .ToList();
    }
}
