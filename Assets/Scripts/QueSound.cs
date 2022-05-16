using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QueSound : MonoBehaviour


{
    
    public AudioClip AudioClipName;
    AudioSource AudioInstance;
    public string infoText;
     public GameObject FogS;


private void OnTriggerEnter(Collider other){
    if(other.tag == "Player"){
   
        AudioInstance.PlayOneShot(AudioClipName);
    FogS = GameObject.Find("FOGTrigger");
        Destroy(FogS);
    }
}

    private void Awake()
    {
        AudioInstance = GetComponent<AudioSource>();

    }

 
}
