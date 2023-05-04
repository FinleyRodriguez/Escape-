using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Exit : MonoBehaviour
{
 
 public GameObject CeilingPosition;
 public GameObject clock1;
 public GameObject clock2;
 public GameObject clock3;
 public GameObject clock4;
 
 public TMP_Text levelUp; 


    // Start is called before the first frame update
    void Start()
    {
        CeilingPosition = GameObject.Find("Ceiling");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider other)
   {
     if (other.CompareTag("Lava"))
     {
       Debug.Log("Dead");
       SceneManager.LoadScene("Dead");
     }
     
     if (other.CompareTag("Exit"))
     {
       
      SceneManager.LoadScene("Win");
       Debug.Log("Exit");      
   
     }

      if (other.CompareTag("clock1"))
     {
     CeilingPosition.transform.position = CeilingPosition.transform.position + new Vector3(0, 10, 0);     
     Destroy(clock1); 
     StartCoroutine(waiter());
     }
     
     if (other.CompareTag("clock2"))
     {
     CeilingPosition.transform.position = CeilingPosition.transform.position + new Vector3(0, 10, 0);     
     Destroy(clock2);
     StartCoroutine(waiter());
     }

      if (other.CompareTag("clock3"))
     {
     CeilingPosition.transform.position = CeilingPosition.transform.position + new Vector3(0, 10, 0);     
     Destroy(clock3);
     StartCoroutine(waiter());
     }

      if (other.CompareTag("clock4"))
     {
     CeilingPosition.transform.position = CeilingPosition.transform.position + new Vector3(0, 10, 0);     
     Destroy(clock4);
     StartCoroutine(waiter());
     }
   }

   IEnumerator waiter()
    {
     levelUp.fontSize = 10;
     levelUp.text = "Extra Time!";
     yield return new WaitForSecondsRealtime(0.1f);
     levelUp.fontSize = 15;
     yield return new WaitForSecondsRealtime(0.1f);
     levelUp.fontSize = 20;
     yield return new WaitForSecondsRealtime(0.1f);
     levelUp.fontSize = 25;
     yield return new WaitForSecondsRealtime(0.1f);
     levelUp.fontSize = 30;
     yield return new WaitForSecondsRealtime(0.1f);
     levelUp.fontSize = 35;
     yield return new WaitForSecondsRealtime(0.1f);
     levelUp.fontSize = 40;
     levelUp.text = "";
    }
}


