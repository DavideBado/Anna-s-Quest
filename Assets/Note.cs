using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour {

    float ColorTime = 2f;
    public Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.tag == "destroy" )
        {
            DestroyObject();
           
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (ColorTime <= 0)
        {
            gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f);
            ColorTime = 1f;
        }
        else ColorTime -= Time.deltaTime;
	}
}
