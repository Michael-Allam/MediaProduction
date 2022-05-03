using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTrail : MonoBehaviour



{
    
    public AudioClip AudioClipName;
    AudioSource AudioInstance;
    public string infoText;
    private GameObject canvas;
    public GameObject test;
    public Light light;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        canvas.GetComponent<Canvas>().enabled = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }


private void OnTriggerEnter(Collider other){
    if(other.tag == "Player"){
        GameObject.FindGameObjectWithTag("TextBox"). GetComponent<Text>().text = infoText;
        canvas.GetComponent<Canvas>().enabled = true;
        AudioInstance.PlayOneShot(AudioClipName);
        test = GameObject.Find("RainPrefab");
        Destroy(test);
        light.shadowStrength = 1.0f;



        // sphere = GameObject.Find("Sphere");
        // Destroy(sphere);//  Destroy(gameObject);


    }
}

private void OnTriggerExit(Collider other){
if(other.tag == "Player"){
        GameObject.FindGameObjectWithTag("TextBox"). GetComponent<Text>().text = "";
         canvas.GetComponent<Canvas>().enabled = false;

    }

}

    private void Awake()
    {
        AudioInstance = GetComponent<AudioSource>();

    }

 
}
