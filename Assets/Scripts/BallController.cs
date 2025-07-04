using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRigidbody2D;
    [SerializeField] float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LaunchBall();
    }

    // Update is called once per frame
    public void LaunchBall()
    {
        // Reset ball position to center
        transform.position = Vector2.zero;

        float x = 0;
        float y = 0;

        // Randomly choose between 0 and 3
        int randomDirection = Random.Range(0, 4);

        /*
                       Y+
                       ↑
                 (-1,1)│(1,1)
                    ↖  │  ↗
                X- ────┼──── X+
                    ↙  │  ↘
                (-1,-1)│(1,-1)
                       ↓
                       Y-
        */
        if (randomDirection == 0)
        {
            x = 1;
            y = 1; // Move diagonally up-right
        }
        else if (randomDirection == 1)
        {
            x = -1;
            y = 1; // Move diagonally up-left
        }
        else if (randomDirection == 2)
        {
            x = 1;
            y = -1; // Move diagonally down-right
        }
        else if (randomDirection == 3)
        {
            x = -1;
            y = -1; // Move diagonally down-left
        }

        // Ensure the Rigidbody2D component is assigned
        // Initialize the ball's velocity to move to the right
        myRigidbody2D.linearVelocity = new Vector2(x, y) * speed;
    }
}
