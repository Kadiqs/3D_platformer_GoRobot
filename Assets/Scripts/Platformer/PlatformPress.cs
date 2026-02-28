using UnityEngine;

public class PlatformPress : MonoBehaviour
{
    //public GameObject player;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject == player)
        //{
        // Play open animation
        animator.SetBool("isOpen", true);
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.gameObject == player)
        //{
        // Play close animation
        animator.SetBool("isOpen", false);
        //}
    }
}
