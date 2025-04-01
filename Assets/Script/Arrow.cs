using UnityEngine;

public class Arrow : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        // Trouve automatiquement le GameManager dans la sc�ne
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trash")) // V�rifie si la fl�che touche un d�chet
        {
            if (gameManager != null)
            {
                gameManager.IncreaseScore(); // Augmente le score
            }

            Destroy(other.gameObject); // D�truit le d�chet
            Destroy(gameObject); // D�truit la fl�che
        }
    }
}
