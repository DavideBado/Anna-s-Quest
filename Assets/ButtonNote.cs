using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNote : MonoBehaviour
{

    public bool IsTrigger;
    public Note m_note;
    public GameManager GameManager;
    public GameObject ButtonNote_Note;

    private void Awake()
    {
        GameManager = GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
     {
        if (other.tag == "NoteTrigger")
        {
            IsTrigger = true;
            Debug.Log("Qualcosa funzona");
            ButtonNote_Note = other.gameObject;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "NoteTrigger")
        {
            IsTrigger = true;
        }
    }
   
    }
