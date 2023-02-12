using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win2048 : MonoBehaviour
{
    [SerializeField] private GameObject _win;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("2048"))
        {

            _win.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
