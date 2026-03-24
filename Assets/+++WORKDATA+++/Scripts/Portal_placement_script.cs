using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class Portal_placement_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Camera cam;
    public GameObject portalOnePrefab;
    public GameObject portalTwoPrefab;
    private bool isPortalOne;

    private Transform currentPortal1Selected;
    private Transform currentPortal2Selected;
    
    void Start()
    {
        cam = Camera.main;

        isPortalOne = portalOnePrefab != null;
    }

    // Update is called once per frame
    void Update()
    {
        PortalOne();
        PortalTwo();
        
        if(Input.GetKeyDown(KeyCode.R))
            OnReload();
    }

    void PortalOne()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 cursorPos = cam.ScreenToWorldPoint(Input.mousePosition);
            GameObject currentPortal = GameObject.FindGameObjectWithTag("portal1");
            
            if(currentPortal != null)
                Destroy(currentPortal);

            currentPortal1Selected = Instantiate(portalOnePrefab, cursorPos, Quaternion.identity).transform;
        }
        else if (currentPortal1Selected != null && Input.GetMouseButton(0))
        {
            Vector2 cursorPos = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPortal1Selected.right = ((Vector2)currentPortal1Selected.position - cursorPos).normalized;
        }
        else if (currentPortal1Selected != null && Input.GetMouseButtonUp(0))
            currentPortal1Selected = null;

    }
    
    void PortalTwo()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 cursorPos = cam.ScreenToWorldPoint(Input.mousePosition);
            GameObject currentPortal = GameObject.FindGameObjectWithTag("portal2");
            
            if(currentPortal != null)
                Destroy(currentPortal);

            currentPortal2Selected = Instantiate(portalTwoPrefab, cursorPos, Quaternion.identity).transform;
        }
        else if (currentPortal2Selected != null && Input.GetMouseButton(1))
        {
            Vector2 cursorPos = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPortal2Selected.right = ((Vector2)currentPortal2Selected.position - cursorPos).normalized;
        }
        else if (currentPortal2Selected != null && Input.GetMouseButtonUp(1))
            currentPortal2Selected = null;

    }

    void OnReload()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
