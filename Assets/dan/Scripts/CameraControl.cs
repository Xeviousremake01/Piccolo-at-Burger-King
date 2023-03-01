using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject player;
    public Vector3 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        cameraPos = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        gameObject.transform.position = cameraPos;
    }
}
