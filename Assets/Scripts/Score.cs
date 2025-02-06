using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI score;
    int scoreVal = 0;
    bool isplaying = true;

    private void Start()
    {
        score.text = scoreVal.ToString();
        gameOverScreen.SetActive(false);
    }

    private void Update()
    {
        if (isplaying == true && Input.GetMouseButtonDown(0))
        {
            scoreVal++;
            score.text = scoreVal.ToString();
        }

        if(scoreVal > 10)
        {
            gameOverScreen.SetActive(true);
            isplaying = false;
        }

        if(isplaying == false && Input.GetKeyDown(KeyCode.Space))
        {
            scoreVal = 0;
            gameOverScreen.SetActive(false);
            isplaying = true;
            score.text = scoreVal.ToString();
        }
    }


}