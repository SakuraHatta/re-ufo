using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private SceneController sceneController;
    [SerializeField]
    private HpController hpController;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameOver();
    }

    private void gameOver(){
        if (hpController.HpCount == 0){
            sceneController.GameOver = true;
        }
    }
}
