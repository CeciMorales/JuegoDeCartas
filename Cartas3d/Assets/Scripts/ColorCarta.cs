using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCarta : MonoBehaviour {
    public Material material;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnMouseDown()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", Color.green);

    }
}
