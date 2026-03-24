using UnityEngine;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    [SerializeField] Scene LoadScene;
    
    public void LoadGameScene()
    {
        SceneManager.LoadScene("TimScene"); 
    }
}
