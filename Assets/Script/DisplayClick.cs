using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayClick : MonoBehaviour
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
        if(displayActive == true)
        {   
            idleMovement = new Vector3(this.transform.position.x,this.transform.localScale.y + (Mathf.Sin(Time.time * freq) * amp) + (this.transform.localScale.y * 0.1f),this.transform.position.z);     
            displayPos.position = idleMovement;
        }
        else{

            idleMovement = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);   
            displayPos.position = idleMovement;
        }
        
    }

    void OnMouseDown()
    {
        Debug.Log("[ONCLICK] Clicking display");
        Debug.Log("[ONCLICK] POS: " + displayPos.position.x + " " + displayPos.position.y + " " + displayPos.position.z);
        if(displayActive == false)
        {
            Debug.Log("[ONCLICK] Opening display");
            displayActive = true;
        }
        else
        {
            Debug.Log("[ONCLICK] Hidding display");
            displayActive = false;
        }
        
        //         
    }
}
