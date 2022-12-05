using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private SceneController sceneController;
    [SerializeField]
    private HpController hpController;
    [SerializeField]
    private UfoController ufoController;

    
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
        /*if (ufoController.Alien){   // ここに問題あり
            Debug.Log("gameover");
            sceneController.GameOver = true;
        }*/

        if (hpController.HpCount == 0){
            sceneController.GameOver = true;
        }
    }
}
