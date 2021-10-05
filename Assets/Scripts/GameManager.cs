using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int lives;
    public int score;
    public int gem;
    public int starsCount;
    public Text score_Text;
    public GameObject heart3;
    public GameObject heart2;
    public GameObject heart1;
    public GameObject gameOverBox;
    public GameObject victoryBox;
    public GameObject endgame;

    public GameObject mainCamera;

    private void Start()
    {
        score_Text.text = "0";
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
    public void exitGame()
    {
        Application.Quit();
    }

    public void AddPoint()
    {
        score++;
        if (score == starsCount)
        {
            victoryBox.SetActive(true);
        }
    }
    public void WinGame()
    {
        endgame.SetActive(true);
    }

    public void ShowScore()
    {
        score_Text.text = score.ToString();
    }

    public void LoseLive()
    {
        lives--;
        if (lives == 2)
        {
            heart3.SetActive(false);
            StartCoroutine(mainCamera.GetComponent<CameraShake>().Shake(0.4f, 0.06f));
        }
        if (lives == 1)
        {
            heart2.SetActive(false);
            StartCoroutine(mainCamera.GetComponent<CameraShake>().Shake(0.4f, 0.06f));
        }
        if (lives == 0)
        {
            heart1.SetActive(false);
            StartCoroutine(mainCamera.GetComponent<CameraShake>().Shake(0.4f, 0.06f));
            gameOverBox.SetActive(true);
        }

    }
   
    public void LoseAllLive()
    {
        lives--;
        if (lives == 2)
        {
            lives--;
            heart3.SetActive(false);
        }
        if (lives == 1)
        {
            lives--;
            heart2.SetActive(false);
        }
        if (lives == 0)
        {
            heart1.SetActive(false);
            StartCoroutine(mainCamera.GetComponent<CameraShake>().Shake(0.4f, 0.06f));
            gameOverBox.SetActive(true);
        }

    }

}
