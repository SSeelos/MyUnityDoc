using UnityEngine;

/// <summary>
/// not an editor script -> placed in a regular script file.
/// </summary>
public class MyPropertyAttribute : PropertyAttribute
{
    public float min;
    public float max;
    public MyPropertyAttribute(float min, float max)
    {
        this.min = min;
        this.max = max;
    }
}

