using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int Score = 0;
    public Text scoretext;
    public void UpdateScore(int value)
    {
        Score += value;
        scoretext.text = "Score : " + Score;
    }
}
