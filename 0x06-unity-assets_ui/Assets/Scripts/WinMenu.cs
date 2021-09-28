using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void MainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void Next(){
        string level = SceneManager.GetActiveScene().name;
        char slice = level[6];
        int ls = slice - '0';
        if (ls < 3){
            string l = "Level0" + (ls + 1).ToString();
            PlayerPrefs.SetString("Prev", l);
            Time.timeScale = 1;
            SceneManager.LoadScene(l);
        }
        else
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
