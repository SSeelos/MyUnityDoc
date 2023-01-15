using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class VectorExt
{
    public static Vector2 GetRandomDir()
    {
        //return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        return Random.insideUnitCircle;
    }
    public static Vector2 GetVectorFromAngle(this Vector2 vector, float angle)
    {
        float angleRad = angle * (Mathf.PI / 180f);
        return new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
    }
    public static Vector2 VectorTo(this Vector2 origin, Vector2 position)
    {
        return position - origin;
    }
    public static Vector3 VectorTo(this Vector3 origin, Vector3 position)
    {
        return position - origin;
    }
    public static Vector2 AverageDirection(this Vector2 vectorA, Vector2 vectorB)
    {
        return (vectorA.normalized + vectorB.normalized).normalized;
    }
    public static float Distance(this Vector2 vectorA, Vector2 vectorB)
    {
        return Vector2.Distance(vectorA, vectorB);
    }
    public static float Distance(this Vector3 vectorA, Vector3 vectorB)
    {
        return Vector3.Distance(vectorA, vectorB);
    }
    public static Vector2 AverageDirection(params Vector2[] vectors)
    {
        if (vectors.Length == 0)
            return Vector2.zero;

        Vector2 tempVec = vectors.FirstOrDefault();
        if (vectors.Length == 1)
            return tempVec;

        foreach (var vector in vectors)
        {
            if (vector == Vector2.zero)
                continue;
            if (vector == tempVec)
                continue;

            tempVec = tempVec.AverageDirection(vector);
        }

        return tempVec;
    }
    public static Vector2 GetMeanVector(List<Vector2> vectors)
    {
        Vector2 result = Vector2.zero;
        if (vectors.Count == 0)
            return result;

        foreach (var vector in vectors)
        {
            result += vector;
        }

        result /= vectors.Count;

        return result;
    }
    public static Vector2 GetMeanOf(List<Transform> transforms)
    {
        return TransformExtensions.GetMeanPosition(transforms);
    }
    public static Vector2 GetMeanOf(List<GameObject> gos)
    {
        return TransformExtensions.GetMeanPosition(gos);
    }
    public static float GetMaxDistance(List<Vector2> vectors)
    {
        float distance = 0;
        if (vectors.Count == 0)
            return distance;

        var vecTemp = vectors.FirstOrDefault();

        foreach (var vector in vectors)
        {
            distance = Mathf.Max(vecTemp.Distance(vector), distance);
        }

        return distance;
    }
    public static float GetMaxDistance(List<Transform> transforms)
    {
        return TransformExtensions.MaxDistance(transforms);
    }
    public static float GetMaxDistance(List<GameObject> gameObjects)
    {
        return TransformExtensions.MaxDistance(gameObjects);
    }
}

