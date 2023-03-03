using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        //boundaries
        if(gameObject.transform.position.x < -11.5)
        {
            gameObject.transform.position = new Vector2(-11.5f, gameObject.transform.position.y);
        }
        if (gameObject.transform.position.x > 13)
        {
            gameObject.transform.position = new Vector2(13, gameObject.transform.position.y);
        }
        if (gameObject.transform.position.y > 8.8)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, 8.8f);
        }
        if (gameObject.transform.position.y < -12.8)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, -12.8f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.score = 0;
            SceneManager.LoadScene("Gameover");
        }
    }
}
