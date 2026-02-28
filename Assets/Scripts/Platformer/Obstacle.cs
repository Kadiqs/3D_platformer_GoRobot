using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public UIManager UImanager;
    [SerializeField] bool DamageObj = true;
    private void Start()
    {

        UImanager = UIManager.instance;
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            if (DamageObj) UImanager.ShowGameOver();
            else
            {
                UImanager.ShowVictory();
            }
        }
    }
}
