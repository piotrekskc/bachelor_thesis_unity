using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayScript : MonoBehaviour {


    
    void Start()
    {



        if (Application.isPlaying)
        {
            Display.displays[1].Activate();
        }
     }

        

    

   
}
