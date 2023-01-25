using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    public GameObject dead_menu;
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("2"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("4"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("8"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("16"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("32"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("64"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("128"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("256"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("512"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("1024"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (col.gameObject.CompareTag("2048"))
        {
            dead_menu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
