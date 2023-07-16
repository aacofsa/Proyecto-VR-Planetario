using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour
{
    public GameObject planerPivot;
    public GameObject ring;
    public float rotationSpeed;
    public float traslationSpeed;
    public bool hasRotation;
    public bool hasTraslation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasRotation){
            this.transform.Rotate(0, rotationSpeed, 0, Space.Self);
            if(ring){
                ring.transform.position = this.transform.position;
            }
        }
        if(hasTraslation && planerPivot){
            this.transform.RotateAround(planerPivot.transform.position, Vector3.up, traslationSpeed * Time.deltaTime);
        }
        
    }
}
