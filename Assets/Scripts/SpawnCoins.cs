using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{

    public GameObject coin;

    void Start()
    {
        InvokeRepeating("Spawn", 3f, 3f);
    }


    void Spawn()
    {
        float random = Random.Range(-4.48f,5.16f);
        GameObject Clone = Instantiate(coin, new Vector3(0, random, 0), Quaternion.identity);
        Destroy(Clone, 10);
    }
}
