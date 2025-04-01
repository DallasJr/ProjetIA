using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Méthode pour changer de scène
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
