using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject spawnObject;
    [SerializeField] private float timer;
    [SerializeField] private float time = 0.01f;
   


    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(timer >= time)
        {
            timer -= timer;
            Instantiate(spawnObject, new Vector2(Random.RandomRange(-1.88f, 1.88f), 3f), Quaternion.identity);
        }
    }
}
