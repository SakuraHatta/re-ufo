using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private FadeController fadeController;

    public bool SceneMove = true;
    public bool GameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sceneControll();
    }

    private void sceneControll(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();     // Escキーで終了
        }

        if (SceneMove){
            if (Input.GetKeyDown(KeyCode.Return)){
                // TittleSceneからGameSceneに移動
                if (SceneManager.GetActiveScene().name == "TittleScene"){
                    SceneMove = false;
                    fadeController.FadeOutStart(0, 0, 0, 0, "GameScene");
                }
                // EndSceneからTittleSceneに移動
                if (SceneManager.GetActiveScene().name == "EndScene"){
                    SceneMove = false;
                    fadeController.FadeOutStart(0, 0, 0, 0, "TittleScene");
                }
            }

            // GameSceneからEndSceneに移動
            if (GameOver){
                SceneMove = false;
                    fadeController.FadeOutStart(0, 0, 0, 0, "EndScene");
            }
        }
    }
}
