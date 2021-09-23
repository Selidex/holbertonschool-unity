using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect(int level){
        string l = "Level0" + level.ToString();
        SceneManager.LoadScene(l);
    }
    public void Options(){
        PlayerPrefs.SetString("Prev", "MainMenu");
        SceneManager.LoadScene("Options");
    }

    public void Exit(){
        Debug.Log("Exited");
        Application.Quit();
    }

    
}
