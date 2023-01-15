using UnityEngine;


public class RelCharacter : MonoBehaviour
{
    IActionValues actionValues;
    public MoveActions character;

    private void Awake()
    {
        actionValues = GetComponent<IActionValues>();
        Instantiate(character);
        character.SetActionValues(actionValues);

    }
}
