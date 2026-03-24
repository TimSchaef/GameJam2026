using UnityEngine;
using TMPro; // Falls du TextMeshPro nutzt (empfohlen)

public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60f; // Startzeit in Sekunden
    public bool timerIsRunning = false;
    
    public TMP_Text timeText;       // Referenz zum UI-Text
    public GameObject losePanel;    // Referenz zum Lose-Panel

    //private bool win1;

    private void Start()
    {
        // Timer starten
        timerIsRunning = true;
        losePanel.SetActive(false); // Sicherstellen, dass das Panel am Anfang aus ist
        
    }

    void Update()
    {
       // win1 = GetComponent<WinManager>().win;
       // if (win1 == true)
        {
           // Time.timeScale = 0f;
        }
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Zeit abgelaufen!");
                timeRemaining = 0;
                timerIsRunning = false;
                GameOver();
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        // Berechnet Minuten und Sekunden
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        losePanel.SetActive(true);   // Lose-Panel anzeigen
        Time.timeScale = 0f;         // Das Spiel komplett pausieren
    }
}
