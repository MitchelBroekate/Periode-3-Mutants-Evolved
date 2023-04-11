using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GamePause = false;
    public GameObject pauseMenuUI;
    public GameObject UI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            UI.SetActive(false);

            Pause();
        }
    }


    public void Resume()
    {
        UI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GamePause= false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
