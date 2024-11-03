using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score;
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = score.ToString(); 
    }

    public void EndGame()
    {
        Debug.Log("Game Over");
    }

    void OnMouseDown()
    {
        score++;
    }
}
