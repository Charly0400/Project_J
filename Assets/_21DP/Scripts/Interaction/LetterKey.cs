using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterKey : Item
{

    public string letter;

    public override void OnPickUp()
    {
        Inventory.SaveItem(letter);
        //Level_Manager.SendToPool(this.gameObject);
        gameObject.SetActive(false);
    }
}
