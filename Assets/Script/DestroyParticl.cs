using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticl : MonoBehaviour{
    [SerializeField] private float _timer;
    private void Start(){
        Destroy(gameObject, _timer);
    }
}