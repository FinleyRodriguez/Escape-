using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crushing : MonoBehaviour
{
  
   
    // Start is called before the first frame update
    void Start()
{
    StartCoroutine(waiter());
}

IEnumerator waiter()
{
       
       yield return new WaitForSeconds(1);
       for(;;) {
        
         transform.position = transform.position + new Vector3(0 , -1, 0);
         yield return new WaitForSeconds(2);

    }

        

    
}
    // Update is called once per frame
    void Update()

    {
        
        

    }


    


 

}


