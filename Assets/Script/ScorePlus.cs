using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlus : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private int _scoreTop;
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _scoreTopText;
    [SerializeField] private bool _activeScore;
    
    private void Start()
    {
        _scoreTop = PlayerPrefs.GetInt("TopScore0", _scoreTop);
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(_activeScore == true)
        {
            _score += 2;
            if(_score == 2)
            {
                _score += 0;
            }
            if(_score >= _scoreTop)
            {
                _scoreTop = _score;
                PlayerPrefs.SetInt("TopScore0", _scoreTop);
            }
            _scoreText.text = "Очков: " + _score.ToString();
            _scoreTopText.text = "Рекорд: " +_scoreTop.ToString();
            
            
            
        }
        
    }
   
    
}
