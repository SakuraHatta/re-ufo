using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static int score = 0;

    [SerializeField]
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddScore(){
        score += 10;
        scoreText.text = score.ToString() + "pt";
    }
}
