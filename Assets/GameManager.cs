using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
    public List<ButtonNote> ButtonNoteManager = new List<ButtonNote>();
    public Note Note;
    ButtonNote A_ButtonNote, S_ButtonNote, D_ButtonNote;
    GameObject CosoNero;

    // Use this for initialization
    void Start()
    {
        A_ButtonNote = GameObject.Find("Trigger A").GetComponent<ButtonNote>();
        S_ButtonNote = GameObject.Find("Trigger S").GetComponent<ButtonNote>();
        D_ButtonNote = GameObject.Find("Trigger D").GetComponent<ButtonNote>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Debug.Log(Score);
    }
    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.A) && A_ButtonNote.IsTrigger == true)

        {
            AddScore();
            Destroy(A_ButtonNote.ButtonNote_Note);
            A_ButtonNote.IsTrigger = false;

        }

        if (Input.GetKeyDown(KeyCode.S) && S_ButtonNote.IsTrigger == true)
           
        {
            AddScore();
            Destroy(S_ButtonNote.ButtonNote_Note);
            S_ButtonNote.IsTrigger = false;
                        
        }
        if (Input.GetKeyDown(KeyCode.D) && D_ButtonNote.IsTrigger == true)

        {
            AddScore();
            Destroy(D_ButtonNote.ButtonNote_Note);
            D_ButtonNote.IsTrigger = false;

        }
    }

    public void AddScore()
    {
        Score += 100;
     
    }

    
}




