using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPrint : MonoBehaviour
{
    
    

    public void a()
    {
        
       
        foreach (KeyValuePair<string,string>Bruh1 in Referencias2.variableString)
        {
            Debug.Log(Bruh1);
      
        }
        foreach (KeyValuePair<string, int> Bruh in Referencias2.variableInt)
        {
            Debug.Log(Bruh);

        }
    }
    
      
    

}
