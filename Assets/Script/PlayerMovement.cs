using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{ 
    public int playerSpeed;
    public Transform vrCamera;
    public float toggleAngle;
    public bool moveForward;

    public Vector3 coordsScene;

    private float delay = 0.3f;
    private float clickTime = 0.0f;

    private Transform cam;
    private float timeStamp;
    private float holdTime;

   
    // Start is called before the first frame update
    void Start()
    {
        moveForward = false;
        cam = vrCamera;
    }

    // Update is called once per frame
    void Update()
    {
        // MOUSE MODE

        // if(Input.GetMouseButtonDown(0) && !moveForward){
        //     clickTime = Time.time;
        // }

        // if(Input.GetMouseButtonUp(0) && !moveForward){
        //     if(Time.time - clickTime <= delay){
        //     Debug.Log("click");
        //     }
        // }

        // if(Input.GetMouseButton(0)){
        //     if(Time.time - clickTime > delay){
        //         Debug.Log("move");
        //         moveForward = true;
        //     }
        // }

        // if (moveForward)
        // {
        //     transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            
        // }

        // if(Input.GetMouseButtonUp(0) && moveForward){
        //     moveForward = false;
        // }


        //TOUCH MODE

        if(Input.GetTouch(0).phase == TouchPhase.Began && !moveForward){
            clickTime = Time.time;
        }

        if(Input.GetTouch(0).phase == TouchPhase.Ended && !moveForward){
            if(Time.time - clickTime <= delay){
            Debug.Log("click");
            }
        }

        if(Input.GetTouch(0).phase == TouchPhase.Stationary ||  Input.GetTouch(0).phase == TouchPhase.Moved){
            if(Time.time - clickTime > delay){
                Debug.Log("move");
                moveForward = true;
            }
        }

        if (moveForward)
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            
        }

        if(Input.GetTouch(0).phase == TouchPhase.Ended && moveForward){
            moveForward = false;
        }

//Raycast
        // if(Input.GetMouseButtonDown(0)){
        //     timeStamp = Time.time + holdTime;
        // }

        // Raycast
        // RaycastHit hit;
        // if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit)){
        //     // Hitted floor collider
        //     if(hit.transform.tag == "Planeta"){
        //         //menuManager.NotifyCameraViewedPoint(hit.point);
            
        //         if(Input.GetMouseButtonUp(0)){
        //             // Return conditions w/o hit
        //             if(hit.point == null)
        //                 return;
            
        //             // Check if the button was held over the time threshold for hold status
        //             if (Time.time >= timeStamp)
        //             {
        //                 //notify holded click
        //             }
        //             else
        //             {
        //                 //notify nromal click
        //             }

        //             timeStamp = Mathf.Infinity;

        //             Debug.Log(hit.transform.name + " Game Object Clicked! ");
        //         }
        //     }
        // }


    }

    public void setCoordsScene(Vector3 coords)
    {   
        
        coordsScene = coords;

        Debug.Log(coordsScene);
    }

}
