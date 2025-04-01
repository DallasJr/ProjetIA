using UnityEngine;
using TMPro; // N'oublie pas d'importer TextMesh Pro

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // R�f�rence publique pour le TextMeshProUGUI
    private int score = 0;

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score : " + score.ToString();
    }
}
