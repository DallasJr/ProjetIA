using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject player;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // Flèches gauche/droite ou A/D
        transform.position += new Vector3(moveX * moveSpeed * Time.deltaTime, 0, 0);
        
        if (moveX < 0)
        {
            player.transform.rotation = Quaternion.Euler(0,-180, 0);

        } else
        {
            player.transform.rotation = Quaternion.Euler(0, 0, 0);

        }

    }
}
