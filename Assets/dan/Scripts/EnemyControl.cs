using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyControl : MonoBehaviour
{
    
    public Transform target;
    public Rigidbody2D rb;

    //movement variables
    public Vector2 moveDirection;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //find player
        target = GameObject.Find("Player").transform;
        //get rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if there is a target
        if (target)
        {
            //where do I move
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
    }

    private void FixedUpdate()
    {
        if(target)
        {
            //how fast do I move?
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }
}
