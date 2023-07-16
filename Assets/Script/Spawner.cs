using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab = null;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player 1(Clone)") != null)
        {
            //Debug.Log("PLAYER EXISTE");
        }
        else
        {
            Debug.Log("NO HAY PLAYER");
            GameObject go = Instantiate(prefab);
            go.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
        }
    }
}
