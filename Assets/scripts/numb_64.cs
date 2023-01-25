using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numb_64 : MonoBehaviour
{

    public GameObject spawnObject;
    public bool destroyed = false;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (destroyed) return;

        if (other.gameObject.CompareTag("64"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);


            other.gameObject.GetComponent<numb_64>().destroyed = true;
            Instantiate(spawnObject, transform.position, Quaternion.identity);
        }
    }
    
}
