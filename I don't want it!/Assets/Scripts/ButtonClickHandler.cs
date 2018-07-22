using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour {

    public GameObject bomb;

    [Header("Player 1")]
    public int Player1Score = 0;
    public Text Player1ScoreText;

    [Space]

    [Header("Player 2")]
    public int Player2Score = 0;
    public Text Player2ScoreText;

    private void Awake()
    {
        Player1ScoreText = GameObject.Find("TextPlayer1Score").GetComponent<Text>();
        Player1ScoreText.text = "0";

        Player2ScoreText = GameObject.Find("TextPlayer2Score").GetComponent<Text>();
        Player2ScoreText.text = "0";
    }

    public void Player1()
    {
        bomb.transform.Translate(transform.up / 5);

        Player1Score++;
        Player2Score--;
        Player1ScoreText.text = Player1Score.ToString();
        Player2ScoreText.text = Player2Score.ToString();
    }

    public void Player2()
    {
        bomb.transform.Translate(transform.up / -5);

        Player2Score++;
        Player1Score--;
        Player2ScoreText.text = Player2Score.ToString();
        Player1ScoreText.text = Player1Score.ToString();
    }
}
