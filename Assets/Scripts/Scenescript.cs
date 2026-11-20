using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}