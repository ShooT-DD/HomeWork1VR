using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : MonoBehaviour
{
    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            if(light.enabled == false)
                light.enabled = true;
            else
                light.enabled = false;
        }
            
    }
}
