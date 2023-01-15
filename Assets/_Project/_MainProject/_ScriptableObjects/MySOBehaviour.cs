using UnityEngine;

[CreateAssetMenu(menuName = AssetMenuConstants.MenuName.ScriptableObject + "/MySOBehaviour")]
public class MySOBehaviour : ScriptableObject, IStrategyBehaviour
{
    public void OnAwake()
    {
        throw new System.NotImplementedException();
    }

    public void OnFixedUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void OnStart()
    {
        throw new System.NotImplementedException();
    }

    public void OnUpdate()
    {
        throw new System.NotImplementedException();
    }
}
