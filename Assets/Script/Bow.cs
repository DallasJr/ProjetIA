using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform spawnPoint;
    public float arrowSpeed = 1000f; // La vitesse de tir
    public float gravityScale = 0.01f; // La gravité de la flèche (peut être ajustée)

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Clic gauche
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        // Créer la flèche à la position de lancement
        GameObject arrow = Instantiate(arrowPrefab, spawnPoint.position, Quaternion.identity);

        // Calculer la direction vers la souris
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Ne garder que les coordonnées X et Y

        // Calculer la direction normalisée de la flèche vers la souris
        Vector2 direction = (mousePosition - spawnPoint.position).normalized;

        // Calculer l'angle de rotation en radians et le convertir en degrés
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle = angle - 90;
        // Appliquer la rotation à la flèche
        arrow.transform.rotation = Quaternion.Euler(0, 0, angle);

        // Obtenir le Rigidbody2D de la flèche
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

        // Ajouter une force pour lancer la flèche
        // Appliquer une force dans la direction du tir
        rb.gravityScale = gravityScale; // Appliquer la gravité
        rb.AddForce(direction * arrowSpeed, ForceMode2D.Impulse); // Lancer la flèche avec une impulsion
    }
}
