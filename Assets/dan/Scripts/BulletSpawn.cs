using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{

    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        Instantiate(bullet, gameObject.transform);
    }
}
