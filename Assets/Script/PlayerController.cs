using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // Flèches gauche/droite ou A/D
        transform.position += new Vector3(moveX * moveSpeed * Time.deltaTime, 0, 0);
    }
}
