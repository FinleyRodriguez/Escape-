using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textScript : MonoBehaviour
{

public TMP_Text canvasText; 
public GameObject FirstPersonControllerPosition;
public GameObject CeilingPosition;
public TMP_Text distanceToExit;
public GameObject Exit;

    // Start is called before the first frame update
    void Start()
    {
       


}
    // Update is called once per frame
    void Update()
    {
canvasText.text = "Distance to ceiling: " + Mathf.RoundToInt(CeilingPosition.transform.position.y - FirstPersonControllerPosition.transform.position.y).ToString();
    

distanceToExit.text = Mathf.RoundToInt(Vector3.Distance (FirstPersonControllerPosition.transform.position, Exit.transform.position)).ToString();

if(Mathf.RoundToInt(Vector3.Distance (FirstPersonControllerPosition.transform.position, Exit.transform.position)) < 20)
{
distanceToExit.color =Color.green;
}

if(Mathf.RoundToInt(Vector3.Distance (FirstPersonControllerPosition.transform.position, Exit.transform.position)) > 20)
{
distanceToExit.color =Color.white;
}

if(Mathf.RoundToInt(Mathf.RoundToInt(CeilingPosition.transform.position.y - FirstPersonControllerPosition.transform.position.y)) < 15)
{
canvasText.color = Color.red;
}

if(Mathf.RoundToInt(Mathf.RoundToInt(CeilingPosition.transform.position.y - FirstPersonControllerPosition.transform.position.y)) > 15)
{
canvasText.color = Color.white;
}

    }
   
}
