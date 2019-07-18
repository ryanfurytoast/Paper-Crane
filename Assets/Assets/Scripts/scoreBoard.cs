using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreBoard : MonoBehaviour
{
    int score = 0;
    Text scoreText;

    // Use this for initialization
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    public void ScoreHit(int scorePerHit)
    {
        score = score + scorePerHit;
        scoreText.text = score.ToString();
    }

    public void checkScore()
    {
        if (score == 100)
        {
           SceneManager.LoadScene(3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkScore();
    }
}







