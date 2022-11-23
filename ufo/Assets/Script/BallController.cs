using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ballMove();     // 弾の移動
        ballDestroy();  // 画面外で消去

    }

    private void ballMove(){
        pos.y += speed * Time.deltaTime;
        this.transform.position = pos;
    }

    private void ballDestroy(){
        if (pos.y > 5.15f){
            Destroy(this.gameObject);
        }
    }
    
    // ufoに当たったら消去
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "ufo"){
            Destroy(this.gameObject);
        }
    }
}