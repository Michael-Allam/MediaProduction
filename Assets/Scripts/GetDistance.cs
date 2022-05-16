using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDistance : MonoBehaviour
{

    public GameObject Player; 
    public float fogValue;

    
    
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {// first var is the property of the player----2nd parameter is the position of object we attatch script to/ are walking towards
        float dist = Vector3.Distance (Player.transform.position, this.transform.position);
        // Debug.Log (dist);
        
        fogValue = 1 / dist * 06.0f;
     
        float fogCalculation = (Mathf.Pow ( fogValue, 3.0f)) / 10;
        RenderSettings.fogDensity = fogCalculation;
    }



}
