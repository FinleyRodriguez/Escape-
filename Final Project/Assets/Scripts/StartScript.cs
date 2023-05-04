using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {
   
   public void GoToScene(string sceneName) {
     SceneManager.LoadScene(sceneName);
     }
     

   
}

