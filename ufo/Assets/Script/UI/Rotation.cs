using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float rotataeSpeed = 100.0f;
    private float angle = 30.0f;
    [SerializeField] private bool direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotataeSpeed) * Time.deltaTime);
    }

    private void rotate(){  // 回転
        if(direction){
            if(transform.localEulerAngles.z < angle){
                transform.Rotate(new Vector3(0, 0, rotataeSpeed) * Time.deltaTime);
            }
            if (Mathf.Round(transform.localEulerAngles.z) == angle){
                Debug.Log("反転");
                direction = false;     // 回転を逆にする判定
            }
        }
        if(!direction){
            transform.Rotate(new Vector3(0, 0, rotataeSpeed * -1.0f) * Time.deltaTime);
            if (Mathf.Round(transform.localEulerAngles.z) == angle * -1.0f){
                Debug.Log("反転");
                direction = true;     // 回転を逆にする判定
            }
        }
    }
}
