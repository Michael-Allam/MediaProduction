using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDistance : MonoBehaviour
{

    public GameObject Player; 
    public float fogValue;
    public float rainIntensity;
    public GameObject rainPrefab;
    // private RainScript rainScript;

    // public GameObject test;
    // private Test t;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // rainPrefab = GameObject.Find("RainPrefab");
        // rainScript = rainPrefab.GetComponent<RainScript>();
        // Debug.Log(RainScript.RainHeight);

        // test = GameObject.Find("TEST");
        // Destroy(test);
        //t = test.GetComponent<Test>();
        //Debug.Log(t.myVariable);

    }

    // Update is called once per frame
    void Update()
    {// first var is the property of the player----2nd parameter is the position of object we attatch script to/ are walking towards
        float dist = Vector3.Distance (Player.transform.position, this.transform.position);
        // Debug.Log (dist);
        
        fogValue = 1 / dist * 06.0f;
        rainIntensity = 1 / dist * 06.0f;
        float fogCalculation = (Mathf.Pow ( fogValue, 3.0f)) / 10;
        RenderSettings.fogDensity = fogCalculation;
    }



}
