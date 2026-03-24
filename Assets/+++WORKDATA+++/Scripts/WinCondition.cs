using System.Collections;
using UnityEngine;

public class WinManager : MonoBehaviour
{
    [SerializeField] int goalAmount = 5;
    [SerializeField] GameObject winPanel;
    [SerializeField] float delayInSeconds = 2.0f;

    public bool win = false;

    private int currentDestroyed = 0;

    private void Start()
    {
        if (winPanel != null)
            winPanel.SetActive(false);
    }

    public void AddScore()
    {
        currentDestroyed++;

        if (currentDestroyed >= goalAmount && !win)
        {
            win = true;
            StartCoroutine(WaitAndShowWinPanel());
        }
    }

    IEnumerator WaitAndShowWinPanel()
    {
        yield return new WaitForSeconds(delayInSeconds);

        if (winPanel != null)
        {
            Time.timeScale = 0f; // Spiel pausieren
            winPanel.SetActive(true);
        }
    }
}