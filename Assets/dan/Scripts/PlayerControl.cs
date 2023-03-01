using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    //movement variables
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //defining movement inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //movement
        transform.Translate(Vector2.right * Time.deltaTime * horizontalInput * moveSpeed);
        transform.Translate(Vector2.up * Time.deltaTime * verticalInput * moveSpeed);
    }
}
