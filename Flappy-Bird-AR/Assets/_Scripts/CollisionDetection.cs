using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;
    
    private void OnTriggerEnter(Collider other)
    {
        gameController.HandleGameOver();
    }
}
