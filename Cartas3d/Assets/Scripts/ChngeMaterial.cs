using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChngeMaterial : MonoBehaviour {

    
    

    public Material uno;
    public Material dos;
    public Material tres;

    public GameObject Object;


	// Use this for initialization
	void Start () {
        
        int num = Random.Range(1, 4);
        Debug.Log("number"+num);

        if (num == 1)
        {
            Object.GetComponent<MeshRenderer>().material = uno;

        }
        else if (num == 2)
        {
            Object.GetComponent<MeshRenderer>().material = dos;

        }
        else if (num == 3)
        {
            Object.GetComponent<MeshRenderer>().material = tres;

        }
        

        

    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
