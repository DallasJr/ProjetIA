using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // M�thode pour changer de sc�ne
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
