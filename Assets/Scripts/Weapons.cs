using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;


class Weapons : IUsable
{
    public string weaponType = "Dagger";
    public void UseItem()
    {
        Debug.Log("Slashed with " + weaponType);
    }
}