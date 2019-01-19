using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour {


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
		
	}
}
