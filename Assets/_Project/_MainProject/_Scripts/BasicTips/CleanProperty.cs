using System;
using System.Collections;
using UnityEngine;

public class CleanProperty : MonoBehaviour
{
    [field: SerializeField]
    public string autoProperty { get; private set; }


    [SerializeField]
    int _myProperty;
    public int MyProperty
    {
        get => _myProperty;
        set
        {
            _myProperty = Mathf.Clamp(value, minValue, maxValue);
            OnSetProperty();
        }
    }
    private void OnSetProperty()
    {
        OnMyPropertyChanged?.Invoke(MyProperty);
        Debug.Log("property changed: " + this._myProperty + ", " + this.Percent + "%", this);

    }

    public Action<int> OnMyPropertyChanged;


    public int minValue;
    public int maxValue;

    private void OnValidate() => MyProperty = _myProperty;

    public float Percent => (float)MyProperty / maxValue * 100;

    public void MyStartCoroutine()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        while (MyProperty <= 10)
        {

            MyProperty += 1;

            yield return null;
        }

    }

}
