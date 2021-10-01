using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
   private bool isTouch;
   public GameObject gameManager;
    
   private void Start()
    {
         isTouch = false;
    }
   


   private void OnTriggerEnter2D(Collider2D collision)
   {
      if(collision.tag == "Bomb" && isTouch == false)
       {
            isTouch = true;
            gameManager.GetComponent<SoundManager>().PlayBombFX();
            gameManager.GetComponent<GameManager>().LoseLive();
            StartCoroutines("WaitState");
       }

      if(collision.tag == "Star" && isTouch == false)
       {
            isTouch = true;
            gameManager.GetComponent<GameManager>().AddPoint();
            gameManager.GetComponent<GameManager>().ShowScore();
            StartCoroutines("WaitState");
        }
    }   
   

    private IEnumerator WaitState()
   {
        yield return new WaitForSeconds(0.4f);
        isTouch = false;
   }
   
}
