using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script : MonoBehaviour
{
    private Rigidbody2D ball_RigidBody2D;
    Vector3 Direction = new Vector3(0, -10, 0);
    // Start is called before the first frame update
    void Start()
    {
        ball_RigidBody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direction * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Paddle")
        {
            Direction = new Vector3(0, 10, 0);
        }
                
    }

}
