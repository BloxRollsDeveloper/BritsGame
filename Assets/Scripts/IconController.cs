using UnityEngine;
using UnityEngine.SceneManagement;

public class IconController : MonoBehaviour
{
   public void EnterLivingQuarters()
    {
        SceneManager.LoadScene("LivingQuarters");
    }
    public void EnterKitchen()
    {
        SceneManager.LoadScene("Kitchen");
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void ToStationView()
    {
        SceneManager.LoadScene("StationView");
    }
}
