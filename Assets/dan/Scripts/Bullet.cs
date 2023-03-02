using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    public GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.Find("bulletSpawner");
        transform.rotation = spawn.transform.rotation;
        gameObject.transform.parent = null;
        Invoke("SelfDestruct", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
    }

    void SelfDestruct()
    {
        Destroy(gameObject);
    }
}
