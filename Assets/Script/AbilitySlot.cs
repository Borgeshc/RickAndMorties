using UnityEngine;
using System.Collections;

public class AbilitySlot : MonoBehaviour
{
    public KeyCode keycode;
    Ability ability;

    void Start()
    {
        ability = GetComponentInChildren<Ability>();
    }
    void NewAbility()
    {
        ability = GetComponentInChildren<Ability>();
    }

    void Update()
    {
        if(Input.GetKeyDown(keycode))
        {
            ability.FireAbility();
        }
    }
}
