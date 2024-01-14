using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject DustNBattery;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    private Scene current;
    void Start(){
        current = SceneManager.GetActiveScene();
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        DustNBattery.SetActive(true);
        Time.timeScale = 1f;
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if(current.name == "Game" && !GameIsPaused){
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        GameIsPaused = false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        DustNBattery.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
