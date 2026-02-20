using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("2TopOliwer");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
