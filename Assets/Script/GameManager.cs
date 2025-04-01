using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
