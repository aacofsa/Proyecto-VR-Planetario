using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoAlTocar : MonoBehaviour
{
    public AudioSource audioGolpe;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Projectile")
        {
            audioGolpe.Play();
        }
    }
}
