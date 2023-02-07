using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private string _numberBlock;
    [SerializeField] private GameObject _block;
    [SerializeField] private GameObject _particl;
    [SerializeField] private bool destroyed = false;
    private Collider2D _col;
   
    public void  OnCollisionEnter2D(Collision2D other)
    {
        if( other.gameObject.CompareTag(_numberBlock))
        {
            
            Destroy(gameObject);
            Destroy(other.gameObject);
            if (destroyed) return;
            other.gameObject.GetComponent<Block>().destroyed = true;
            Instantiate(_block, transform.position, Quaternion.identity);
            Instantiate(_particl, transform.position, Quaternion.identity);
            
        }
        
    }
    


}

