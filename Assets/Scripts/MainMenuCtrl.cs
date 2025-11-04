using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuCtrl : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("StationView");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
