using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Deadscreen : MonoBehaviour {
   

void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }



   public void GoToScene(string sceneName) {
     SceneManager.LoadScene(sceneName);
     }
     

   
}
