using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : MonoBehaviour
{
  
private void OnTriggerEnter(Collider other)
{

    Inventory Inventory = other.GetComponent<Inventory>();
    if (Inventory != null)
    {  
        Inventory.FlowersCollected();
        gameObject.SetActive(false);
    }   
}


}
