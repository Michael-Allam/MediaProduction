using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressSpacebar : MonoBehaviour
{
   public SkyboxBlender skyboxScript;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            skyboxScript.SkyboxBlend();
        }     
    }
}
