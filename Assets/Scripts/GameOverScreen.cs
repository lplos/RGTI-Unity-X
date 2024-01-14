using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //public Text pointsText;
    public GameObject counter;
    public void Setup(){
        gameObject.SetActive(true);
        counter.SetActive(false);
        Time.timeScale = 0f;
        FindObjectOfType<AudioManager>().StopPlaying("Roomba");
        FindObjectOfType<AudioManager>().Play("Game Over");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void RestartButton(){
        SceneManager.LoadScene("Game");
        counter.SetActive(true);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void ExitButton(){
        SceneManager.LoadScene("Title Screen");
        Time.timeScale = 1f;
    }
}
