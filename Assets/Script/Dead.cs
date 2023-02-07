using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dead : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _deadMenu;
    [SerializeField] private bool _activeScore;
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("2") || col.gameObject.CompareTag("4") || col.gameObject.CompareTag("8") || col.gameObject.CompareTag("16") || col.gameObject.CompareTag("32") || col.gameObject.CompareTag("64") || col.gameObject.CompareTag("128") || col.gameObject.CompareTag("256") || col.gameObject.CompareTag("512") || col.gameObject.CompareTag("1024") || col.gameObject.CompareTag("2048"))
        {
            _deadMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if(_activeScore == true)
        {
            _score++;
            print(_score);
        }
        
    
    }
}
