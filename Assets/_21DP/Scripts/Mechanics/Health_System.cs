using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_System : MonoBehaviour
{
    [SerializeField]
    private float hp;

    [SerializeField]
    private Image healtBar;


    private void OnTriggerEnter (Collider other)
    {
        Damage_Object damageobject = other.gameObject.GetComponent<Damage_Object>();

        if (damageobject != null)
            TakeDamage(damageobject.damageAmount);
    }

    void TakeDamage(float damage)
    {
        Debug.Log("Taking Damage");
        hp -= damage;
        float fillamount  = hp*.01f;
    }

    
    void Update()
    {
        if (hp <= 0)
        {
            Debug.Log("Estoy muerto");
        }
    }
}
