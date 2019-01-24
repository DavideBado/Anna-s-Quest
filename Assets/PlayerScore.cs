using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

    public int ScoreValue;

    public void Score(int amount)
    {
        ScoreValue += amount;

    }

}
