using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingProjectile : MonoBehaviour
{
    
    void Start()
    {
        Destroy(this.gameObject, 1.0f);
    }

    
    void OnCollisionEnter (Collision collision)
    {
        //Destroy (gameObject, 1.0f);
        GameObject prefab = Resources.Load("BigExplosionEffect") as GameObject;
        GameObject BulletImpactMetalEffect = Instantiate (prefab) as GameObject;
        BulletImpactMetalEffect.transform.position = transform.position;

        Destroy (BulletImpactMetalEffect, 1);
        Destroy (gameObject);
        
    }
}
