using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Descarga : MonoBehaviour
{
   
   public void OpenApp(string sceneName)
    {
        
        SceneManager.LoadScene(sceneName);
        Mordchanger.Mord = 1; 



        
    }
}
