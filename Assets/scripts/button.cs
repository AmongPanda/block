using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button : MonoBehaviour
{
       
    public void restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void main()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public GameObject menu;
    public void open_menu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }
    public void exit_menu()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
}

