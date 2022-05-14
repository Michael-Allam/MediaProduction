using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{

public int NumberOfFlowers { get; private set; }  

public UnityEvent<Inventory> OnFlowersCollected;


public void FlowersCollected()
{
    NumberOfFlowers++;
    OnFlowersCollected.Invoke(this);
}

}
