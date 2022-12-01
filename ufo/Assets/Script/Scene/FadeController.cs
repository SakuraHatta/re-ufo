using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeController : MonoBehaviour
{
    private bool fadeOut = false;
    private bool fadeIn = true;
    private float fadeSpeed = 0.75f;

    [SerializeField]
    private Image fadeImage = default;
    [SerializeField]
    private SceneController sceneController;

    private float red, green, blue, alpha;      // 赤、緑、青、透明度
    private string afterScene;


    // Start is called before the first frame update
    void Start()
    {
        SetRGBA(0, 0, 0, 1);
        SceneManager.sceneLoaded += fadeInStart;    // シーン遷移完了時にフェードイン開始
    }

    // Update is called once per frame
    void Update()
    {
        fade();
    }

    private void fadeInStart(Scene scene, LoadSceneMode mode){      // フェードイン開始
        fadeIn = true;
    }

    public void FadeOutStart(int red, int green, int blue, int alpha, string nextScene){    // フェードアウト開始
        SetRGBA(red, green, blue, alpha);
        SetColor();
        fadeOut = true;
        afterScene = nextScene;
    }

    private void SetColor(){    // 色代入関数
        fadeImage.color = new Color(red, green, blue, alpha);
    }

    private void SetRGBA(int r, int g, int b, int a){   // 色の値を設定
        red = r;
        green = g;
        blue = b;
        alpha = a;
    }

    private void fade(){    // フェードの再生
        if (fadeIn){    // フェードインを1回再生
            alpha -= fadeSpeed * Time.deltaTime;    // 透明度を徐々に下げる(明るくなる)
            SetColor();
            if (alpha <= 0){    // 完全に透明になると再生終了
                fadeIn = false;
            }
        }

        if (fadeOut){   // フェードアウトの再生
            alpha += fadeSpeed * Time.deltaTime;    // 透明度を徐々に上げる(暗くなる)
            SetColor();
            if(alpha >= 1){     // 完全に表示されると再生終了
                fadeOut = false;
                sceneController.SceneMove = true;
                SceneManager.LoadScene(afterScene);     // 次のシーンに移動
            }
        }
    }
}
