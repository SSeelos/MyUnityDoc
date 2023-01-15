using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = AssetMenuConstants.MenuName.ScriptableObject_SceneType + "/WorldScene")]
public class WorldScene : _SceneType
{
    [SerializeField]
    SceneAsset Scene;

    public void LoadScene()
    {
        var scene = (SceneAsset)Scene;
        SceneManager.LoadSceneAsync(scene.name);
        SceneManager.LoadSceneAsync(this.SceneReference);
    }
}
