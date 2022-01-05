using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    void IncreaseScore()
    {
        score++;
    }

    void IncreaseScore(int increment)
    {
        score += increment;
    }

    void ResetScore()
    {
        score = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Ball"))
        {
            IncreaseScore();
        }
    }
}
