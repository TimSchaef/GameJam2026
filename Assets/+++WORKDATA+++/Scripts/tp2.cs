using UnityEngine;

public class tp2_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Camera cam;
    
    public GameObject portal2;
    void Start()
    {
        cam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
       return;
        
        if (Input.GetMouseButtonDown(1))
        {
            Vector2 cursorPos = cam.ScreenToWorldPoint(Input.mousePosition);
            GameObject portal = GameObject.FindGameObjectWithTag("portal2");
            if (portal2 !=null)
            {
                DestroyImmediate(portal);
            }
            
            Instantiate(portal2, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);
            portal = this.gameObject;


        }
    }
}