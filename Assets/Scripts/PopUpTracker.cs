using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpTracker: MonoBehaviour
{
     
  
     private GameObject CanvasFlowers;
  
    // Start is called before the first frame update
    void Start()
    {
        

        CanvasFlowers = GameObject.FindGameObjectWithTag("CanvasFlowers");
        CanvasFlowers.GetComponent<Canvas>().enabled = false;
     
    }

 
private void OnTriggerEnter(Collider other){
    if(other.tag == "Player"){
      CanvasFlowers.GetComponent<Canvas>().enabled = true;

    }
}

 
 
}
