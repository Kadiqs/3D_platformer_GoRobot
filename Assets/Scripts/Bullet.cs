using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public Rigidbody rb;
    void Start()
    {
        // When the bullet spawns, make it fly forward immediately
        // "transform.right" means the red X-axis of the bullet (forward in 2D)
        rb.linearVelocity = transform.forward * speed;
    }
    private void OnTriggerEnter(Collider other)
    {
        // 1. Ignore the Player (so we don't shoot ourselves)
        if (other.CompareTag("Player")) return;

        // 2. Check if we hit an Enemy
        Enemy enemy = other.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        // 3. Destroy the bullet immediately upon hitting anything
        // (Walls, ground, or enemies)
        Destroy(gameObject);
    }
}
