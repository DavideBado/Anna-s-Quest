using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
    public List<ButtonNote> ButtonNoteManager = new List<ButtonNote>();
    public Note Note;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }
    void CheckInput()
    {

        if (Input.GetKeyDown(KeyCode.A) && ButtonNoteManager[0].IsTrigger == true)
            // Quando abbiamo aggiunto qualcosa alla lista? Siamo sicuri che 0 sia l'oggetto di sinistra? 
            // Che poi neanche abbiamo una transform legata a ButtonNote quindi sinistra di cosa?
        {
            AddScore();
            ButtonNoteManager[0].Note.DestroyObject();
        }

        if (Input.GetKey(KeyCode.S) && ButtonNoteManager[1].IsTrigger == true)
        {

        }

        if (Input.GetKey(KeyCode.D) && ButtonNoteManager[2].IsTrigger == true)
        {

        }

    }

    public void AddScore()
    {
        Score += 100;
        Debug.Log(Score);
    }

    
}




