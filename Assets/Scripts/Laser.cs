using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public float moveSpeed;

    public GameObject explosionPrefab;

    void Start()
    {
        
    }

  
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Boundry")
        {
            Destroy(gameObject);
        }

    }

}
