using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    public GameObject player;
    // Called automatically when another Collider enters this object's Trigger zone.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            // make parent player will move *with* the platform
            other.transform.parent = transform;
        }
    }
    // Called automatically when another Collider exits this object's Trigger zone.
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            // The player will no longer follow the platform's movement
            other.transform.parent = null;
        }
    }

}
