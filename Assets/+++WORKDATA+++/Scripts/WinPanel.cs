using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPanel : MonoBehaviour
{
    [SerializeField] Scene LoadScene;
    
    public void LoadGameScene()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
