using UnityEngine;

public class GameResbawn : MonoBehaviour
{
    [SerializeField]
    private UIManager UImanager;
    //threshold should be less than ground level

    public float threshold;
    private void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            UImanager.ShowGameOver();
            //instant respawn
            //transform.position = new Vector3(6.58f, 1.02f, -11.59f);
        }
    }
}
