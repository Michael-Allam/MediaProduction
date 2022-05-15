using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventoryUi : MonoBehaviour
{
private TextMeshProUGUI flowerText;

    // Start is called before the first frame update
    void Start()
    {
      flowerText = GetComponent<TextMeshProUGUI>();  

    }

public void UpdateFlowerText(Inventory Inventory)
{
    flowerText.text = Inventory.NumberOfFlowers.ToString();
}

    
}
