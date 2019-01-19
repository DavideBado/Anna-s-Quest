using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public GameObject cube;

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Trigger")
        {
            cube.transform.position = new Vector3(-4.215f, -0.83f, -32.712f);
        }
    }
}
