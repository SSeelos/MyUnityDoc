using System;
using System.Collections.Generic;
using UnityEngine;


public static class GameObjectExt
{
    public static void SetLayersRecursively(this GameObject gameObject, int layer)
    {
        gameObject.layer = layer;
        foreach (Transform transform in gameObject.transform)
        {
            transform.gameObject.SetLayersRecursively(layer);
        }
    }
    public static bool CompareLayer(this GameObject gameObject, LayerMask layerMask)
    {
        return layerMask.Compare(gameObject);
    }
    public static bool IsIgnoringCollision(this GameObject gameObject, LayerMask other)
    {
        return gameObject.layer.IsIgnoringCollision(other.ToLayer());
    }
    public static bool IsIgnoringCollision(this GameObject gameObject, GameObject other)
    {
        return gameObject.layer.IsIgnoringCollision(other.layer);
    }
    /// <summary>
    /// Get component in This OR Parent OR Child
    /// </summary>
    public static bool TryGetComponentAll<T>(this GameObject gameObject, out T component)
    {
        if (gameObject.TryGetComponent(out component))
            return true;

        if (gameObject.GetComponentInParent<T>() is T parentComponent)
        {
            component = parentComponent;
            return true;
        }
        if (gameObject.GetComponentsInChildren<T>() is T childComponent)
        {
            component = childComponent;
            return true;
        }

        return false;
    }

    /// <summary>
    /// Get all components in this AND parent AND child
    /// </summary>
    public static bool TryGetComponentsAll<T>(this GameObject gameObject, out T[] component)
    {
        var tempList = new List<T>();

        tempList.AddRange(gameObject.GetComponents<T>());

        tempList.AddRange(gameObject.GetComponentsInParent<T>());

        tempList.AddRange(gameObject.GetComponentsInChildren<T>());

        if (tempList.Count == 0)
        {
            component = Array.Empty<T>();
            return false;
        }

        component = tempList.ToArray();
        return true;
    }
    /// <summary>
    /// Get all components in This OR Parent OR Child
    /// </summary>
    public static bool TryGetComponentsFirstAll<T>(this GameObject gameObject, out T[] component)
    {
        if (gameObject.GetComponents<T>() is T[] comp)
        {
            component = comp;
            return true;
        }

        if (gameObject.GetComponentsInParent<T>() is T[] parentComponent)
        {
            component = parentComponent;
            return true;
        }
        if (gameObject.GetComponentsInChildren<T>() is T[] childComponent)
        {
            component = childComponent;
            return true;
        }

        component = Array.Empty<T>();
        return false;
    }
}

