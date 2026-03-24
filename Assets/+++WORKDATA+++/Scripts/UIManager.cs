using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void GoToMainMenu()
    {
        Time.timeScale = 1f; // Pause zurücksetzen
        SceneManager.LoadScene("MainMenu"); // Name deiner Szene
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Pause zurücksetzen
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Spiel beendet"); // nur im Editor sichtbar
    }
}