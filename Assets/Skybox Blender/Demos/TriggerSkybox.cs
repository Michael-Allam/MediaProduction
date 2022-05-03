using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSkybox : MonoBehaviour
{
    public SkyboxBlender skyboxScript;


    private void OnTriggerEnter(Collider other){
    if(other.tag == "Player"){
    skyboxScript.SkyboxBlend(true);
    //GameObject.FindGameObjectWithTag("TextBox"). GetComponent<Text>().text = infoText;
    //canvas.GetComponent<Canvas>().enabled = true;
    //AudioInstance.PlayOneShot(AudioClipName);
    // sphere = GameObject.Find("Sphere");
    // Destroy(sphere);//  Destroy(gameObject);
    
        }
    }





}
