using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

    public int Score;

    public void score(int amount)
    {
        Score += amount;

    }

}
