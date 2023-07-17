using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
                                
    void Start()
    {
        InvokeRepeating("Spawn",2f,2f);
    }

    
    void Spawn()
    {
        float random = Random.Range(-1.68f,2.56f);
        GameObject Clone=Instantiate(obstacle,new Vector3(0,random,0),Quaternion.identity);
        Destroy(Clone,10);
    }
}
