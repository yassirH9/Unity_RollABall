using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Canvas EscCanvas;
    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            
            Debug.Log("Opening Esc Menu");
            openEscMenu();
            
        }
    }
    public void startGame()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
    public void goTolvl2()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
    public void goTolvl3()
    {
        SceneManager.LoadScene("Level3", LoadSceneMode.Single);
    }
    public void goTolvl4()
    {
        SceneManager.LoadScene("Level4", LoadSceneMode.Single);
    }
    public void goToSelect()
    {
        SceneManager.LoadScene("SelectMenu", LoadSceneMode.Single);
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        Time.timeScale = 1;
    }
    public void hideEscMenu()
    {
        EscCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void openEscMenu()
    {
        EscCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void resume()
    {
        hideEscMenu();
    }
}
