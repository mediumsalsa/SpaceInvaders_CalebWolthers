using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{

    public int lives = 3;
    public Image livesUI;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<BoxCollider2D>().gameObject.tag == "Enemy")
        {
            Destroy(collision.GetComponent<BoxCollider2D>().gameObject);
            lives--;
            if (lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }


}
