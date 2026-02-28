using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;     // The position where the bullet spawns
    public GameObject bullet; // The bullet asset we want to shoot


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("shoot");
            Shoot();
        }

        void Shoot()
        {

            // Logic to spawn the bullet
            if (bullet != null)
            {
                GameObject bullObj = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation) as GameObject;
                Rigidbody rb = bullObj.GetComponent<Rigidbody>();
                rb.linearVelocity = firePoint.forward * 20f;
                Destroy(bullObj, 5f);
            }
        }
    }
}
