using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    float timer, jeda = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > jeda)
        {
            float randX = Random.Range(-8, 8);
            Instantiate(enemy, new Vector2(randX, transform.position.y), Quaternion.identity);
            timer = 0;
        }
    }
}
