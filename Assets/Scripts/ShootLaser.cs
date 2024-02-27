using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{

    public GameObject laserPrefab;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
    }
}
