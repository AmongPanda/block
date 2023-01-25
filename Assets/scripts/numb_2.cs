using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numb_2 : MonoBehaviour
{
    public GameObject spawnObject;
   
    private bool destroyed = false;
    
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (destroyed) return;

        if (other.gameObject.CompareTag("2"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            

            other.gameObject.GetComponent<numb_2>().destroyed = true;
            Instantiate(spawnObject, transform.position, Quaternion.identity);
        }
    }
    
    
}
