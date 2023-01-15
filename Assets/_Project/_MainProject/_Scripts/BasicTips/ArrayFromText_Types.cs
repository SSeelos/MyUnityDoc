using System;
using UnityEngine;

public class ArrayFromText_Types : MonoBehaviour
{
    [Header("dependencies")]
    [SerializeField /*,Required*/]
    TextAsset file;
    [SerializeField]
    Types[] array;
    private void OnValidate()
    {
        var lines = file
            ? file.text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
            : null;

        array = new Types[lines.Length];
        int i = 0;
        foreach (var line in lines)
        {
            array[i] = ConvertTo_Types(line);
            i++;
        }
    }

    private Types ConvertTo_Types(string line)
    {
        var parts = line.Split(',');
        foreach (var part in parts)
        {
            Debug.Log(part);

        }
        return new Types
        {
            propA = parts[0],
            propB = int.TryParse(parts[1], out var b) ? b : 0,
            propC = float.TryParse(parts[2], out var c) ? c : 0,
            propD = ColorUtility.TryParseHtmlString(parts[3], out var d) ? d : Color.white
        };
    }

}
[Serializable]
public class Types
{
    public string propA;
    public int propB;
    public float propC;
    public Color propD;
}
