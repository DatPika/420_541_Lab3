using UnityEngine;

public class BulletComponent : MonoBehaviour
{
    // Speed of the bullet
    public float bulletSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // Add an impulst force in the fowrad direction
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);

        // Destroy the bullet after 5 seconds
        Destroy(gameObject, 5f);
    }
}