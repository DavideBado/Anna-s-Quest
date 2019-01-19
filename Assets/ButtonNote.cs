using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNote : MonoBehaviour
{

    public bool IsTrigger;
    public Note Note;
    public GameManager GameManager;


    private void Awake()
    {
        GameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.ButtonNote == null 
            && Note == null 
            && other.tag == "NoteTrigger")
        {
           // GameManager.ButtonNote = this;
            Note = other.gameObject.GetComponent<Note>();
            GameManager.Note = Note;
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
