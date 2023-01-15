using System;
using UnityEngine;

public class ArrayFromText : MonoBehaviour
{
    [Header("dependencies")]
    [SerializeField /*,Required*/]
    TextAsset file;
    [SerializeField]
    string[] array;

    private void OnValidate()
    {
        array = file
            ? file.text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
            : null;
    }
}
