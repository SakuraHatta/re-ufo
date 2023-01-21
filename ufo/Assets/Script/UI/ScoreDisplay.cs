using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = ScoreController.score.ToString() + "pt";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
