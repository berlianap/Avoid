using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPerisai : MonoBehaviour
{
    float timer, jeda = 5;
    public GameObject perisai;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > jeda)
        {
            Instantiate(perisai, new Vector2(Random.Range(-8, 8), transform.position.y), Quaternion.identity);
            timer = 0f;
        }
    }
}
