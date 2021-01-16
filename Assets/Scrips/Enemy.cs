using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            if (DataScore.perisai > 0) {
                DataScore.score +=1;
				DataScore.perisai -=1;
            }
            else
                Time.timeScale = 0f;

        }
    }
}
