using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle yi;
    int y;
    void Start()
    {
        if(PlayerPrefs.HasKey("Y"))
        {
            y = PlayerPrefs.GetInt("Y");
            if (y == -1){
                yi.isOn = true;
            }
            else{
                yi.isOn = false;
            }

        }
        else{
            PlayerPrefs.SetInt("Y", 1); 
        }
    }
    public void Back(){
        string p = PlayerPrefs.GetString("Prev");
        SceneManager.LoadScene(p);
    }
    public void Apply(){
        if(yi.isOn){
            PlayerPrefs.SetInt("Y", -1);
        }
        else
        {
            PlayerPrefs.SetInt("Y", 1);
        }
        string p = PlayerPrefs.GetString("Prev");
        SceneManager.LoadScene(p);
    }
}
