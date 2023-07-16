using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerClick : MonoBehaviour
{

    public int indexNextSceneToLoad;
    public float coordXScene = 0;
    public float coordYScene = 0;
    public float coordZScene = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           // Debug.Log("[UPDATE] Clicking");
        }
    }

    void OnMouseDown()
    {
        Debug.Log("[ONCLICK] Clicking");
        Debug.Log(indexNextSceneToLoad);

        GameObject.Find("Player 1(Clone)").GetComponent<PlayerCoords>().setCoordsScene(getCoordsScene());
        //this.transform.parent.transform.Find("PlayerCoords").GetComponent<Player>().setCoordsScene(getCoordsScene());
        
        SceneManager.LoadScene(indexNextSceneToLoad);

        

    }

    public Vector3 getCoordsScene()
    {
        Vector3 coordsScene = new Vector3(coordXScene, coordYScene, coordZScene);
        return coordsScene;
    }

}
