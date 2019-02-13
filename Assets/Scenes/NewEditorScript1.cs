using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bricks : MonoBehaviour
{
    private void Awake()
    {
        System.Random rand = new System.Random();
        int numberOfBricks = 5; rand.Next();
        GameObject bricks = new GameObject();
        for (int i = 0; i < numberOfBricks; i++)
        {
            SpriteRenderer SpriteRenderer = bricks.AddComponent<SpriteRenderer>() as SpriteRenderer;
            SpriteRenderer.color = new Color(0.5f, 0.9f, 0.3f, 1.0f);
            BoxCollider2D BC = bricks.AddComponent<BoxCollider2D>() as BoxCollider2D;
            BC.size = new Vector2(2f, 2f);
            Rigidbody2D RB = bricks.AddComponent<Rigidbody2D>() as Rigidbody2D;
            RB.bodyType = RigidbodyType2D.Kinematic;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
