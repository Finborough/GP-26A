using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class ItemScript : MonoBehaviour
{
    void Start()
    {
        Item Weapon = new Weapon();
        Item Potion = new Potion();
        Weapon.UseItem();
        Potion.UseItem();
    }


}
interface Item
{
    void UseItem();
}

class Weapon : Item
{
    public string weaponType = "Dagger";
    public void UseItem()
    {
        Debug.Log("Slashed with " + weaponType);
    }
}

class Potion : Item
{
    public string potionType = "Health";
    public void UseItem()
    {
        Debug.Log("Drank a " + potionType + " potion");
    }
}

