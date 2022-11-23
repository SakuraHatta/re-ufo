using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.0f;

    private Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();     // 左右移動
    }

    private void playerMove(){
        if (Input.GetKey("left")){
            pos.x -= speed * Time.deltaTime;
        }else if (Input.GetKey("right")){
            pos.x += speed * Time.deltaTime;
        }
        if (pos.x <= -8.2f){
            pos.x = -8.2f;   // 画面の左端より左に移動しない
        }
        if(pos.x >= 8.2f){
            pos.x = 8.2f;    // 画面の右端より右に移動しない
        }

        this.transform.position = new Vector2(pos.x, -4.0f);
    }
}