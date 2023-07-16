using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoords : MonoBehaviour
{

    public Vector3 coordsScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setCoordsScene(Vector3 coords)
    {

        coordsScene = coords;
        Debug.Log(coordsScene);

        this.transform.position = coordsScene;
        
    }
}
