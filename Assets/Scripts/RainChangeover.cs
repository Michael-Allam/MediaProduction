using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RainChangeover : MonoBehaviour



{
    
    public AudioClip AudioClipName;
    AudioSource AudioInstance;
    public GameObject test;
    public Light light;

  



private void OnTriggerEnter(Collider other){
    if(other.tag == "Player"){
 
        AudioInstance.PlayOneShot(AudioClipName);
        test = GameObject.Find("RainPrefab");
        Destroy(test);
        light.shadowStrength = 0.6f;


    }
}

    private void Awake()
    {
        AudioInstance = GetComponent<AudioSource>();

    }


}
