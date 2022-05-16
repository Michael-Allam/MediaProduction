using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : MonoBehaviour
{
  public AudioSource collectSound;

private void OnTriggerEnter(Collider other)
{

    Inventory Inventory = other.GetComponent<Inventory>();
    if (Inventory != null)
    {  
         collectSound.Play();
        Inventory.FlowersCollected();
        gameObject.SetActive(false);
    }   
}


}
