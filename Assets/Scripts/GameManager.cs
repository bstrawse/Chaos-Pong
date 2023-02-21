using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Player1Score, Player2Score, Player3Score, Player4Score;
    public BallMove ball1, ball2, ball3;
    public Text p1score;
    public Text p2score;
    public Text p3score;
    public Text p4score;
    private float timerball;

    public void p1s()
    {
        Player1Score++;
        this.p1score.text = Player1Score.ToString();
        ball1.resetPosition();
    }

    public void p2s()
    {
        Player2Score++;
        this.p2score.text = Player2Score.ToString();
        ball1.resetPosition();
    }

    public void p3s()
    {
        Player3Score++;
        this.p3score.text = Player3Score.ToString();
        ball1.resetPosition();
    }

    public void p4s()
    {
        Player4Score++;
        this.p4score.text = Player4Score.ToString();
        ball1.resetPosition();
    }

    private void Start()
    {
    }

    private void Update()
    {


        if (Player1Score == 11 || Player2Score == 11 || Player3Score == 11 || Player4Score == 11)
        {
            ball1.gameObject.SetActive(false);
            ball2.gameObject.SetActive(false);
            ball3.gameObject.SetActive(false);
        }
    }
}
