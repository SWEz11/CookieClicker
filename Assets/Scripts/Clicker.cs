using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Clicker : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnMouseDown()
    {
        score++;
    }
}
