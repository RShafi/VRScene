using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light[] lights;
    public Color[] color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int x = 0; x < lights.Length; x++)
        {
            lights[x].intensity = lights[x].intensity + Input.mouseScrollDelta.y;
        }
    }
}
