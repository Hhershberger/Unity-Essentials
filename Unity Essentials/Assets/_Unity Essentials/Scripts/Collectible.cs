using UnityEngine;

public class Collectible : MonoBehaviour
{
<<<<<<< Updated upstream
=======
    public float rotationSpeed;
    public GameObject onCollectEffect;
>>>>>>> Stashed changes
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
<<<<<<< Updated upstream
    void Update(Transform.Rotate(0,1,0);)
    {
        
=======
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
        // Destroy the collectible
        Destroy(gameObject);
        // instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

>>>>>>> Stashed changes
    }
}
