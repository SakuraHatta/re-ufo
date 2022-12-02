using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 pos;

    public bool Alien = false;
    private bool move = true;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ufoMove();
        ufoDestroy();
    }

    private void ufoMove(){
        if (move){
            pos.x += Mathf.Sin(Time.time) * Time.deltaTime;
            pos.y -= speed * Time.deltaTime;
            this.transform.position = pos;
        }
    }

    private void ufoDestroy(){
        if (pos.y < -3.7f){
            move = false;
            Alien = true;
            //Destroy(this.gameObject);
        }
    }

    // ballに当たったら消去
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "ball"){
            Destroy(this.gameObject);
        }
    }
}
