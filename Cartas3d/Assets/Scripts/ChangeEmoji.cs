using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEmoji : MonoBehaviour {

    public Material monkey;
    public Material cow;
    public Material dog;

    public GameObject Object;


    // Use this for initialization
    void Start()
    {

        int num = Random.Range(1, 4);
        Debug.Log("emoji: "+num);

        if (num == 1)
        {
            Object.GetComponent<MeshRenderer>().material = monkey;

        }
        else if (num == 2)
        {
            Object.GetComponent<MeshRenderer>().material = cow;

        }
        else if (num == 3)
        {
            Object.GetComponent<MeshRenderer>().material = dog;

        }




    }
    // Update is called once per frame
    void Update () {
		
	}
}
