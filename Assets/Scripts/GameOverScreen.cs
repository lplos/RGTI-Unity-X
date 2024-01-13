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
    }
    public void RestartButton(){
        SceneManager.LoadScene("Game");
        counter.SetActive(true);
        Time.timeScale = 1f;
    }
    public void ExitButton(){
        SceneManager.LoadScene("Title Screen");
        Time.timeScale = 1f;
    }
}
