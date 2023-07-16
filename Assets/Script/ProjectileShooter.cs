using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    GameObject prefab;
    void Start()
    {
        prefab = Resources.Load("Projectile") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject Projectile = Instantiate(prefab) as GameObject;
            Projectile.transform.position = transform.position+Camera.main.transform.forward * 2;
            Rigidbody rb = Projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
            
        }
        
    }
}
