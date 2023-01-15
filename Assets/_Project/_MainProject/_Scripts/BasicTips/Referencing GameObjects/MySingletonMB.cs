using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySingletonMB : MonoBehaviour
{
    public static MySingletonMB I { get; private set; }

    private string data;

    private void Awake()
    {
        if (I == null)
        {
            I = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SetData(string data)
    {
        this.data = data;
    }
}
