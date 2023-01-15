using System;
using System.Collections;
using System.Reflection;
using UnityEngine;

[SelectionBase]
public class MyMonoBehaviour : MonoBehaviour
{
    #region Fields & Properties

    #region Some Props

    private int myField;

    private int myPresetField = 100;


    [Header("MyHeader")]
    public int myProperty;

    //does not limit runtime values!
    [Range(0, 100)]
    public int myRangeProperty;

    //make field visible/ editable in editor
    [SerializeField]
    private int myValidateField;
    public int myValidateProperty;

    [Range(0, -100)]
    public int myValidateMin = 0;
    [Range(0, 100)]
    public int myValidateMax;

    //limited at runtime & in editor
    [SerializeField]
    [Range(0, 100)]
    private int _myRange = 100;
    public int MyRange
    {
        get => _myRange;
        set
        {
            _myRange = Mathf.Clamp(value, myValidateMin, myValidateMax);
        }
    }

    [SerializeField]
    MyScriptableObject myScriptableObject;
    #endregion

    #region Clean Property
    [Header("Clean Property")]

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

#if UNITY_EDITOR
    //does not affect runtime values! (editor only)
    private void OnValidate()
    {
        MyProperty = _myProperty;

        myValidateProperty = Mathf.Clamp(myValidateProperty, myValidateMin, myValidateMax);
    }
#endif

    public float Percent => (float)MyProperty / maxValue * 100;
    #endregion

    #region Serializable class
    [Header("Serializable class")]

    public MySerializableClass MySerializableClass;
    public MySerializableClass[] MySerializableClassArray;

    #endregion

    #region Collison Props
    [Header("Collison")]

    [SerializeField]
    private string collisonTag;
    [SerializeField]
    private LayerMask collisonLayerMask;
    #endregion

    #endregion

    public void SetField(int value) => myValidateField = Mathf.Clamp(value, myValidateMin, myValidateMax);

    public int GetField() => myValidateField;

    [ContextMenu("My ContextMenu -> Run Method from Editor")]
    public void RunFromEditor()
    {
        //context highlighted in editor
        Debug.Log("RunFromEditor", context: this);
    }

    #region MonoBehaviour Lifecycle

    #region Init
    private void OnAwake()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        //reference other objects/components
    }
    private void OnEnable()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        //subscribe to events

        StartCoroutine(MyCoroutine());
    }
    private void Start()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        //reference properties on other objects/components
    }
    //Start can be a coroutine
    //IEnumerator Start()
    //{
    //    yield return new WaitForSeconds(1);
    //}

    //Start can be async method
    //async void Start()
    //{
    //    await System.Threading.Tasks.Task.Delay(42);
    //}
    #endregion

    #region Frame
    private void FixedUpdate()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        //Handle input effects

        myRangeProperty -= 1;
        myValidateField -= 1;
        myValidateProperty -= 1;
        MyRange -= 1;
    }

    #region Trigger & Collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {

    }
    private void OnCollisionExit2D(Collision2D collision)
    {

    }
    void ProcessCollision(GameObject collider)
    {
        if (!collider.CompareTag(collisonTag))
            return;
        if (!collider.CompareLayer(collisonLayerMask))
            return;
    }

    #endregion

    private void Update()
    {
        //Handle input
    }

    private void LateUpdate()
    {
        //Camera follow, ...
    }
    private void OnDrawGizmos()
    {
        //draw stuff (debug, visualize logic)

        Gizmos.DrawLine(gameObject.transform.position, gameObject.transform.position + gameObject.transform.up);
    }

    #endregion

    private void OnApplicationPause(bool pause)
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        //Handle pausing
    }

    private void OnDisable()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        //unsubsrcibe form events

        //gets called from Destroy()
    }
    private void OnDestroy()
    {
        DebugLogger.Instance.ClassMethodLog(GetType(), MethodBase.GetCurrentMethod());

        //..
    }

    #endregion
    IEnumerator MyCoroutine()
    {
        for (float counter = 0; counter < 100; counter += 1f)
        {
            //...
            yield return new WaitForSeconds(1);
        }
    }
}
