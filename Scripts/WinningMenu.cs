using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningMenu : MonoBehaviour
{

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
