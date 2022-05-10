using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Manager : MonoBehaviour
{

    public Transform player;
    public static Transform _player;

    public int availableEnemies;
    public static int _availableEnemies;


    // Start is called before the first frame update
    private void Start()
    {

        _player = player;
        _availableEnemies = availableEnemies;


    }


}
