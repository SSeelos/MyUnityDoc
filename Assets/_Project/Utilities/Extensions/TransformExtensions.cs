using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions
{
    public static Vector2 Position2D(this Transform transform)
    {
        return transform.position;
    }
    public static bool InFront(this Transform target, Vector3 positon)
    {
        var direction = positon.VectorTo(target.position).normalized;

        var dot = Vector3.Dot(target.forward, direction);

        return dot >= 0;
    }
    public static Vector2 GetMeanPosition(List<Transform> transforms)
    {
        List<Vector2> positions = GetPositions(transforms);

        return VectorExt.GetMeanVector(positions);
    }


    public static Vector2 GetMeanPosition(List<GameObject> objs)
    {
        List<Vector2> positions = GetPositions(objs);

        return VectorExt.GetMeanVector(positions);
    }


    public static float MaxDistance(List<Transform> transforms)
    {
        List<Vector2> positions = GetPositions(transforms);

        return VectorExt.GetMaxDistance(positions);
    }
    public static float MaxDistance(List<GameObject> gameObjects)
    {
        List<Vector2> positions = GetPositions(gameObjects);

        return VectorExt.GetMaxDistance(positions);
    }
    private static List<Vector2> GetPositions(List<Transform> transforms)
    {
        List<Vector2> positions = new List<Vector2>();

        foreach (var tranform in transforms)
        {
            positions.Add(tranform.position);
        }

        return positions;
    }
    private static List<Vector2> GetPositions(List<GameObject> objs)
    {
        List<Vector2> positions = new List<Vector2>();

        foreach (var obj in objs)
        {
            positions.Add(obj.transform.position);
        }

        return positions;
    }
}