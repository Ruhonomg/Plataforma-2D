using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingGame : MonoBehaviour
{
    public void SceneSelector()
    {
        SceneManager.LoadScene("Level_1");
    }
}
