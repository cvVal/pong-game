using UnityEngine;

public class GoalController : MonoBehaviour
{
    [SerializeField] bool isPlayer1;
    [SerializeField] BallController ballController;
    [SerializeField] GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // PLAYER 1 SCORES
            // If isPlayer1 is false, it means Player 1 scored
            if (!isPlayer1)
            {
                gameManager.Player1Scores();
                ballController.LaunchBall();
            }
            else
            {
                gameManager.Player2Scores();
                ballController.LaunchBall();
            }
        }
    }
}
