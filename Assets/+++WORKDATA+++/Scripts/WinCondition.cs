using UnityEngine;


public class WinManager : MonoBehaviour
{
    [SerializeField] int goalAmount = 5;
    [SerializeField] GameObject winPanel;
    [SerializeField] float delayInSeconds = 2.0f; 

    private int currentDestroyed = 0;

    public void AddScore()
    {
        currentDestroyed++;
        
        if (currentDestroyed >= goalAmount)
        {
         
            StartCoroutine(WaitAndShowWinPanel());
        }
    }

   
    System.Collections.IEnumerator WaitAndShowWinPanel()
    {
       
        yield return new WaitForSeconds(delayInSeconds);

        if (winPanel != null)
        {
            winPanel.SetActive(true);
           
        }
    }
}