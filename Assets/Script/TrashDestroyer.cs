using UnityEngine;

public class TrashDestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trash"))
        {
            Destroy(other.gameObject);
            Debug.Log("Déchet tombé !");
        }
    }
}

