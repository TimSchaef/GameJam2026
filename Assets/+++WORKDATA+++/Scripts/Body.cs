using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class Body : MonoBehaviour
{
    [SerializeField] GameObject debrisParticles;
    void Start()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag =="Player")
        {
            Object.FindFirstObjectByType<WinManager>()?.AddScore();

            
            Instantiate(debrisParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
