using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSelector : MonoBehaviour
{
    public void SceneSelector()
    {
        SceneManager.LoadScene("Level_1");
    }
}
