using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;



class Potions : IUsable
{
    public string potionType = "Health";
    public void UseItem()
    {
        Debug.Log("Drank a " + potionType + " potion");
    }
}