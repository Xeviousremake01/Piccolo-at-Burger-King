using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //enemy that is being spawned
    public GameObject enemy;
    public Transform[] spawnArray;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        spawnPoint = spawnArray[Random.Range(0, spawnArray.Length)];
        Instantiate(enemy, spawnPoint);
    }
}
