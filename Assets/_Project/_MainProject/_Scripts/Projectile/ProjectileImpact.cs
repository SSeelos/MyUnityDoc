using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileImpact : MonoBehaviour
{
    public GameObject explosion;

     void OnCollisionEnter2D()
    {
        Debug.Log("coll");
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
