using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public int starsCount;
    public text score_Text;
    public GameObject heart3;
    public GameObject heart2;
    public GameObject heart1;
    public GameObject gameOverBox;
    public GameObject victoryBox;
    
    private void Start()
    {
        score_Text.text = "0";
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void AddPoint()
    {
        score++;
        if(score == startsCount)
        {
            
        }
    }
    
    public void ShowScore()
    {
        score_Text.text = score.ToString();
    }

    public void LoseLive()
    {
        lives--;
        if(lives == 2)
        {
            heart3.SetActive(false);
        }
        if(lives == 1)
        {
            heart3.SetActive(false);
        }
        if(lives == 0)
        {
            heart3.SetActive(false);
            gameOverBox.SetActive(true);
        }
    }

}
