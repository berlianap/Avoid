using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour
{
    Text score;
    public Text perisai;
    void Start()
    {
        score = GetComponent<Text>();
        DataScore.score = 0;
        DataScore.perisai = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score : "+DataScore.score.ToString();
        perisai.text = "Perisai : " + DataScore.perisai.ToString();
    }
}
