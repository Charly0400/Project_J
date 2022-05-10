using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter_Block : MonoBehaviour
{

    public GameObject J, G, I;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Inventory.J)
                J.SetActive(true);
            if (Inventory.G)
                G.SetActive(true);
            if (Inventory.I)
                I.SetActive(true);
        }
    }
}
