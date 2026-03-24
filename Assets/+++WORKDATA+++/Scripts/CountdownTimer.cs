using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public bool timerIsRunning = false;

    public TMP_Text timeText;
    public GameObject losePanel;

    private WinManager winManager;

    private void Start()
    {
        timerIsRunning = true;
        losePanel.SetActive(false);

        winManager = FindObjectOfType<WinManager>();
    }

    void Update()
    {
        if (!timerIsRunning) return;

        // Stoppt Timer wenn gewonnen wurde
        if (winManager != null && winManager.win)
        {
            timerIsRunning = false;
            return;
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            timerIsRunning = false;
            GameOver();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0f; // Spiel pausieren
    }
}