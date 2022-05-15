using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTrail : MonoBehaviour



{
    
    public AudioClip AudioClipName;
    AudioSource AudioInstance;
    public string infoText;
    private GameObject Canvas;
  
    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        Canvas.GetComponent<Canvas>().enabled = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }


private void OnTriggerEnter(Collider other){
    if(other.tag == "Player"){
        GameObject.FindGameObjectWithTag("TextBox"). GetComponent<Text>().text = infoText;
        Canvas.GetComponent<Canvas>().enabled = true;
        AudioInstance.PlayOneShot(AudioClipName);
     

    }
}

private void OnTriggerExit(Collider other){
if(other.tag == "Player"){
        GameObject.FindGameObjectWithTag("TextBox"). GetComponent<Text>().text = "";
         Canvas.GetComponent<Canvas>().enabled = false;

    }

}

    private void Awake()
    {
        AudioInstance = GetComponent<AudioSource>();

    }

 
}
