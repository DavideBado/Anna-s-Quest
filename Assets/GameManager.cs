using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
    public List<ButtonNote> ButtonNote = new List<ButtonNote>();
    public Note Note;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkInput();
    }
    void checkInput()
    {

        if (Input.GetKeyDown(KeyCode.A) && ButtonNote[0].IsTrigger == true)
        {
            AddScore();
            ButtonNote[0].Note.DestroyObject();
        }

        if (Input.GetKey(KeyCode.S) && ButtonNote[1].IsTrigger == true)
        {

        }

        if (Input.GetKey(KeyCode.D) && ButtonNote[2].IsTrigger == true)
        {

        }

    }

    public void AddScore()
    {
        Score += 100;
        Debug.Log(Score);
    }

    
}




