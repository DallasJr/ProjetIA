using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform spawnPoint;
    public float arrowSpeed = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Clic gauche
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        // Créer la flèche
        GameObject arrow = Instantiate(arrowPrefab, spawnPoint.position, Quaternion.identity);

        // Calculer la direction vers le curseur
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // On enlève la profondeur

        Vector2 direction = (mousePosition - spawnPoint.position).normalized; // Direction normalisée

        // Calculer l'angle de rotation
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Appliquer la rotation à la flèche
        arrow.transform.rotation = Quaternion.Euler(0, 0, angle);

        // Ajouter une force pour lancer la flèche
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction * arrowSpeed;  // Utiliser velocity et non linearVelocity
    }
}
