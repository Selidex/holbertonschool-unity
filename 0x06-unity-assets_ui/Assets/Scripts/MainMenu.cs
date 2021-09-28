using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    void Start(){
        PlayerPrefs.SetInt("Y", 1);
    }
    public void LevelSelect(int level){
        string l = "Level0" + level.ToString();
        PlayerPrefs.SetString("Prev", l);
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
