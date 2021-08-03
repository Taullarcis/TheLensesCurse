using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] string GameScene = "";
    [SerializeField] GameObject InfoMenu = null;
    [SerializeField] GameObject MainUI = null;

    public void StartGame()
    {
        SceneManager.LoadScene(GameScene);
    }

    public void OpenInfo()
    {
        MainUI.SetActive(false);
        InfoMenu.SetActive(true);
    }

    public void CloseInfo()
    {
        InfoMenu.SetActive(false);
        MainUI.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
