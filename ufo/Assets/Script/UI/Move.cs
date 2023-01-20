using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector2 pos;
    private bool flag = true;
    private float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move(){
        if (flag){
            pos.x += speed * Time.deltaTime;
            if(pos.x >= 7.5f){
                flag = false;
            }
        }
        else if (!flag){
            pos.x -= speed * Time.deltaTime;
            if(pos.x <= 4.5f){
                flag = true;
            }
        }

        this.transform.position = new Vector2(pos.x, -4.4f);
    }
}
