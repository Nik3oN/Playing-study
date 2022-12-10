using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DiscordiaDialogo : MonoBehaviour
{
    public GameObject Discordia;
    public GameObject Link;
    public void OpenApp(string sceneName)
    {
        if (Mordchanger.Mord == 0)
        {
            SceneManager.LoadScene(sceneName);
        }
        if(Mordchanger.Mord == 2)
        {
            var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // use 'Instantiate' to clone our prefab; this 3-arg version 
            // lets us set the position and rotation for the new object
            var newprint = Instantiate(
                Discordia,
                new Vector3(mousePosition.x, mousePosition.y, 0),
                Quaternion.identity);
            Destroy(Link);
        }
    }
}
