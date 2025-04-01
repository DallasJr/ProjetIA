using UnityEngine;

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
        }
    }
}

