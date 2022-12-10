using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mordchanger: MonoBehaviour
{
    public static int Mord = 0;
    
    private string sceneName2 = "MordNormal";
    public void OpenApp(string sceneName)
    {
        if(Referencias.Passlvl1 != true)
        {
            if (Mord == 0)
            {
                SceneManager.LoadScene(sceneName2);
            }
            if (Mord == 2)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        
    }
}
