using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool pause = false;
    public GameObject pausemenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
            if (pause){
            Pause();
        }
        else
        {
            Resume();
        }
        }
        
    }
    
    public void Pause(){
        Time.timeScale = 0;
        pausemenu.gameObject.SetActive(true);        
    }

    public void Resume(){
        Time.timeScale = 1;        
        pausemenu.gameObject.SetActive(false);
        pause = false;
    }

    void OnGUI(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Restart(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void Options(){
        Time.timeScale = 1;
        PlayerPrefs.SetString("Prev", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
