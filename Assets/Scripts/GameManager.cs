using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int player1Score = 0;
    int player2Score = 0;

    [SerializeField] TextMeshProUGUI player1ScoreText;
    [SerializeField] TextMeshProUGUI player2ScoreText;

    public void Player1Scores()
    {
        player1Score++;
        Debug.Log("Player 1 Score: " + player1Score);
        player1ScoreText.text = player1Score.ToString();
    }

    public void Player2Scores()
    {
        player2Score++;
        Debug.Log("Player 2 Score: " + player2Score);
        player2ScoreText.text = player2Score.ToString();
    }

    public void ResetScores()
    {
        player1Score = 0;
        player2Score = 0;
        Debug.Log("Scores reset. Player 1: " + player1Score + ", Player 2: " + player2Score);
    }
}