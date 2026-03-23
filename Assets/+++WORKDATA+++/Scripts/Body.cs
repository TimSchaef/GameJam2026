using UnityEngine;

public class Body : MonoBehaviour
{
    [SerializeField] GameObject debrisParticles;
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Instantiate(debrisParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
