using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;

    // This function is called by the Bullet script
    public void TakeDamage(int damage)
    {

        Debug.Log("Damaged");
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Add death animation or sound logic here
        Destroy(gameObject);
    }
}
