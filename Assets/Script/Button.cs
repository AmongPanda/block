using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    [SerializeField] private int _numberScene;
    [SerializeField] private GameObject MenuOne;
    [SerializeField] private GameObject MenuTwo;
    
    // рестар выбранного уровня
    public void Restart()
    {
        SceneManager.LoadScene(_numberScene);
        Time.timeScale = 1;
    }
    // перемещение между сценами
    public void OpenSceneOne()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void OpenSceneTwo()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void Main()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    // открытие и закрытие меню под номером один
    public void OpenMenuOne()
    {
        MenuOne.SetActive(true);
        Time.timeScale = 0;
    }
    public void ExitMenuOne()
    {
        MenuOne.SetActive(false);
        Time.timeScale = 1;
    }
    // открытие и закрытие меню под номером два
     public void OpenMenuTwo()
    {
        MenuTwo.SetActive(true);
        Time.timeScale = 0;
    }
    public void ExitMenuTwo()
    {
        MenuTwo.SetActive(false);
        Time.timeScale = 1;
    }
}

