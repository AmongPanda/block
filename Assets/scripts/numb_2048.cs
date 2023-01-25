using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numb_2048 : MonoBehaviour
{

    public GameObject spawnObject;
    public GameObject panelWin;
    public bool destroyed = false;
    public bool active;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (destroyed) return;

        if (other.gameObject.CompareTag("2048"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);


            other.gameObject.GetComponent<numb_2048>().destroyed = true;

            if(active == true)
            {
                panelWin.SetActive(true);
            }
            else
            {
                Instantiate(spawnObject, transform.position, Quaternion.identity);
            }
            
        }
    }
    
    
}
