using System.Collections.Generic;
using UnityEngine;

public abstract class _RelNToN : MonoBehaviour
{
    [SerializeField]
    protected List<GameObject> Rel;
    [SerializeField]
    protected List<Transform> RelTo;
}
