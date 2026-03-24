using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Scene LoadScene;
    
    public void LoadGameScene()
    {
        SceneManager.LoadScene("TimScene"); 
    }
}
