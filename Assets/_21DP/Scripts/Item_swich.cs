using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_swich : Interactable
{
    public GameObject item;


    public override void OnInteraction()
    {
        item.SetActive(true);
    }
}
