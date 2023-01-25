using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numb_1024 : MonoBehaviour
{

    public GameObject spawnObject;
    public bool destroyed = false;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (destroyed) return;

        if (other.gameObject.CompareTag("1024"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);


            other.gameObject.GetComponent<numb_1024>().destroyed = true;
            Instantiate(spawnObject, transform.position, Quaternion.identity);
        }
    }
   
}
