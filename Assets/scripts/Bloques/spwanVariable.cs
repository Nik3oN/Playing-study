 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanVariable : MonoBehaviour
{
    public GameObject BloqueVariable;
    private int i = 0;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        DontDestroyOnLoad(BloqueVariable);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void BotonVariable()
    {
        i++;
        if(Pythonchecker.WhichProgram == 2)
        {
            Referencias.TaskEdit[0] = true;
        }
        if(Pythonchecker.WhichProgram == 3 && i==2)
        {
            Referencias.TaskEdit[1] = true;
        }
        if (Pythonchecker.WhichProgram == 6)
        {
            Referencias.TaskEdit[1] = true;

        }
        var mousePosition = Camera.main.ScreenToWorldPoint(
                Input.mousePosition
            );
            // use 'Instantiate' to clone our prefab; this 3-arg version 
            // lets us set the position and rotation for the new object
            var newBloqueVariable = Instantiate(
                BloqueVariable,
                new Vector3(mousePosition.x, mousePosition.y, 0),
                Quaternion.identity
            );
       
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger!");

    }
}
