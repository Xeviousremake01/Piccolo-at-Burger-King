using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    //movement variables
    public float horizontalInput;
    public float verticalInput;
    [SerializeField] float moveSpeed;
    [SerializeField] float rotationSpeed;

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
        transform.Rotate(Vector3.back * Time.deltaTime * horizontalInput * rotationSpeed);
        transform.Translate(Vector2.right * Time.deltaTime * verticalInput * moveSpeed);
    }
}
