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

    private void OnTriggerEnter(Collider other) // ????? Forse questo script è quello mancante nelle note? Ma allora perché avere due script e richiamare il secondo qui?
    {
        if (GameManager.ButtonNoteManager == null // ??????? Se sono qui come è possibile che la lista sia == null?
            && Note == null 
            && other.tag == "NoteTrigger")
        {
           // GameManager.ButtonNote = this;
            Note = other.gameObject.GetComponent<Note>(); // Quindi questo script è pensato per andare nel trigger della barra nera?
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
