using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLooked : Interactable
{
    public int neceseryItem = 3;
    public override void OnInteraction()
    {
        Debug.Log("Trying to acces");

        if (Inventory.HasItems(neceseryItem))
            OpenLock();

        else
            Debug.Log("Can not open");

    }

    void OpenLock()
    {
        Debug.Log("Open");
        GetComponent<Animator>().enabled = true;

    }
}





