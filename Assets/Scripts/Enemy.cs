using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float moveSpeed = 3;

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundry")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y -1, transform.position.z);
            moveSpeed *= -1;
        }
    }

}
 