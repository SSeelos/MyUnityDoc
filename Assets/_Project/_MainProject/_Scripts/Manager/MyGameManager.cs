using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public enum SceneIndex
{
    //this should be alsways loaded -> never be loaded
    //PersistentScene = 0,
    SampleScene = 1,
    SceneManagement = 2,
}
public class MyGameManager : MonoBehaviour
{
    public static MyGameManager I;
    [SerializeField]
    private SceneIndex SceneToLoad;
    [SerializeField]
    private SceneIndex SceneToLoadNext;

    public InputAction LoadSceneAction;

    private void Awake()
    {
        if (I == null)
            I = this;
        LoadSceneAction.Enable();
        SceneManager.LoadSceneAsync((int)SceneToLoad, LoadSceneMode.Additive);
    }
    private void OnEnable()
    {
        LoadSceneAction.performed += (ctx) => LoadScene();
    }
    private void OnDisable()
    {
        LoadSceneAction.performed += (ctx) => LoadScene();
    }



    public void LoadScene()
    {
        SceneManager.UnloadSceneAsync((int)SceneToLoad);
        SceneManager.LoadSceneAsync((int)SceneToLoadNext, LoadSceneMode.Additive);
    }
}
