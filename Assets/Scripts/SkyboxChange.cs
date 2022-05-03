using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{ 
    public Material Sky;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = Sky;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
