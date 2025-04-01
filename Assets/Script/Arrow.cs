using UnityEngine;

public class Arrow : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        // Trouve automatiquement le GameManager dans la scène
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trash")) // Vérifie si la flèche touche un déchet
        {
            if (gameManager != null)
            {
                gameManager.IncreaseScore(); // Augmente le score
            }

            Destroy(other.gameObject); // Détruit le déchet
            Destroy(gameObject); // Détruit la flèche
        }
    }
}
