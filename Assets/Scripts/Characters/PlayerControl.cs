using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public GameObject gameManager;

    private bool isTouch;

    private void Start()
    {
        isTouch = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb" && isTouch == false)
        {
            isTouch = true;
            gameManager.GetComponent<SoundManager>().PlayBombFX();
            gameManager.GetComponent<GameManager>().LoseLive();
            StartCoroutine("WaitState");
        }
        if (collision.tag == "Stars" && isTouch == false)
        {
            isTouch = true;
            gameManager.GetComponent<GameManager>().AddPoint();
            gameManager.GetComponent<GameManager>().ShowScore();
            gameManager.GetComponent<SoundManager>().PlayStarFX();
            StartCoroutine("WaitState");
        }
        if (collision.tag == "Gem" && isTouch == false)
        {
            isTouch = true;
            gameManager.GetComponent<SoundManager>().PlayGemFX();
            gameManager.GetComponent<GameManager>().WinGame();
            StartCoroutine("WaitState");
        }
        if (collision.gameObject.tag == "Vacio")
        {
            Debug.Log("Muerte por caida");
            gameManager.GetComponent<GameManager>().LoseAllLive();
            StartCoroutine("WaitState");
        }
        if (collision.gameObject.tag == "Pinchos")
        {
            gameManager.GetComponent<GameManager>().LoseAllLive();
            StartCoroutine("WaitState");
        }
        
    }
    
    private IEnumerator WaitState()
    {
        yield return new WaitForSeconds(0.4f);
        isTouch = false;
    }

}
