using UnityEngine;

public enum LayerNames
{
    //built-in
    Default,
    TransparentFX,
    IgnoreRaycast,
    Water,
    UI,
}

public static class LayerNamesExt
{
    public static string AsText(this LayerNames layerNames)
    {
        string txt = null;
        switch (layerNames)
        {
            case LayerNames.IgnoreRaycast:
                txt = "Ignore Raycast";
                break;
            default:
                layerNames.ToString();
                break;
        }

        return txt;
    }
}
public static class LayerMaskExt
{
    public static LayerMask NewLayerMask(int layer) => layer.ToLayerMask();
    public static LayerMask ToLayerMask(this int layer)
        => 1 << layer;
    public static int ToLayer(this LayerMask layerMask)
        => layerMask.value;
    public static LayerMask Merge(this LayerMask layerMask, LayerMask otherLayerMask)
        => layerMask | otherLayerMask;
    public static LayerMask Invert(this LayerMask layerMask)
        => ~layerMask;


    public static LayerMask NameToLayer(LayerNames layerNames)
    {
        return LayerMask.NameToLayer(layerNames.AsText());
    }

    public static string ToName(this LayerMask layerMask)
    {
        return LayerMask.LayerToName(layerMask.ToLayer());
    }

    //same thing?
    //private bool IsInLayerMask(this GameObject gameObject, LayerMask layerMask)
    //{
    //    return ((layerMask.value & (1 << gameObject.layer)) > 0);
    //}
    public static bool Compare(this LayerMask layerMask, GameObject gameObject)
    {
        return layerMask.Compare(gameObject.layer);
    }
    public static bool Compare(this LayerMask layerMask, int layer)
    {
        return layerMask.Compare(layer.ToLayerMask());
    }
    public static bool Compare(this LayerMask layerMask, LayerMask otherLayerMask)
    {
        return layerMask == layerMask.Merge(otherLayerMask);
    }
    //public static bool Compare(this LayerMask layerMasks, LayerMask otherMask)
    //{
    //    //
    //}
    /// <summary>
    /// Check if collisions are ignored
    /// (defined in physics collision matrix)
    /// </summary>
    public static bool IsIgnoringCollision(this LayerMask layerMask, LayerMask other)
    {
        return layerMask.ToLayer().IsIgnoringCollision(other.ToLayer());
    }
    public static bool IsIgnoringCollision(this int layer, int other)
    {
        return Physics2D.GetIgnoreLayerCollision(layer, other);
    }
}

