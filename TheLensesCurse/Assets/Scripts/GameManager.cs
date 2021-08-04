using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isPaused = false;
    [SerializeField] GameObject pauseMenu = null;
    [SerializeField] GameObject fog = null;

    private float counter = 0.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ClosePause();
            }
            else
            {
                OpenPause();
            }
        }

        if (!isPaused)
        {
            counter += Time.deltaTime;
            if(counter >= 5.0f)
            {
                Color color = fog.GetComponent<Image>().color;
                print(color.a);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    fog.GetComponent<Image>().color = new Color(color.r, color.g, color.b, 0.0f);
                    counter = 0.0f;
                }
                
                if(counter <= 15.0f)
                {
                    fog.GetComponent<Image>().color = new Color(color.r, color.g, color.b, 225.0f / (225.0f / (counter - 5.0f)));
                }
            }
        }
    }

    public void OpenPause()
    {
        isPaused = true;
        Cursor.visible = true;
        pauseMenu.SetActive(true);
    }

    public void ClosePause()
    {
        isPaused = false; 
        Cursor.visible = false;
        pauseMenu.SetActive(false);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
