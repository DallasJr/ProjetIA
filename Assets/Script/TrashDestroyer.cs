using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashDestroyer : MonoBehaviour
{
    public GameObject[] hearts;
    private int life = 5;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trash"))
        {
            Destroy(other.gameObject);
            life -= 1;
            Destroy(hearts[life]);

            if (life == 0 ){
                SceneManager.LoadScene("GameOverScene"); // Remplace "GameOverScene" par le nom de ta scène
            }


            // if = 0 alors charge une autre scene 
        }
        
    }
}

