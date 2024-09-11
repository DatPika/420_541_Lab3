using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    // Write down your variables here
    int score;

    private void Awake()
    {
        Instance = this;
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log(score);
    }
}
