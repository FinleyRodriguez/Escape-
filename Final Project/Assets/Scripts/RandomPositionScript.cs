using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositionScript : MonoBehaviour
{
 
public GameObject Portal1Position;
public GameObject Portal2Position;
public GameObject Portal3Position;
public GameObject Portal4Position;



   int random = 0;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0, 5);
        //random = 1;
        if(random == 1)
        {
    transform.position = new Vector3 (Portal1Position.transform.position.x, Portal1Position.transform.position.y + 3, Portal1Position.transform.position.z);
        }
        if(random == 2)
        {
           transform.position = new Vector3 (Portal2Position.transform.position.x, Portal2Position.transform.position.y + 3, Portal2Position.transform.position.z);
        }
        if(random == 3)
        {
           transform.position = new Vector3 (Portal3Position.transform.position.x, Portal3Position.transform.position.y + 3, Portal3Position.transform.position.z);
        }
        if(random == 4)
        {
           transform.position = new Vector3 (Portal4Position.transform.position.x, Portal4Position.transform.position.y + 3, Portal4Position.transform.position.z);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
