using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    public string myName;
    [SerializeField]
    public string myClass;
    [SerializeField]
    public int level;

    public string GetName()
    {
        return myName;
    }

    public string GetClass()
    {
        return myClass;
    }

    public int GetLevel()
    {
        return level;
    }
}

