using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void HowtoGame()
    {
        SceneManager.LoadScene("HowToScene");
    }

    public void OpenCredit()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void BacktoMain()
    {

        SceneManager.LoadScene("MenuScene");
    }
}
