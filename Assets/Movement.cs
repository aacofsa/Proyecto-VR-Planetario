using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float amp = 0.3f;
    public float freq = 1.0f;
    private Transform displayPos;
    private Vector3 idleMovement;
    private bool displayActive = false;
    
    // Start is called before the first frame update
    void Start()
    {
        displayPos = this.gameObject.transform.GetChild(0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
           
        idleMovement = new Vector3(this.transform.position.x,this.transform.position.y + (Mathf.Sin(Time.time * freq) * amp) + 1.1f,this.transform.position.z);     
        displayPos.position = idleMovement;

        
    }
}
