using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    /**
    * @brief cannonにアタッチ
    */

    [SerializeField]
    private GameObject ballPrefab;
    
    private Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ballShoot();    // 弾生成
    }

    private void ballShoot(){
        if(Input.GetKeyDown(KeyCode.Space)){
            pos = this.transform.position;
            Instantiate(ballPrefab, new Vector2(pos.x, -3.25f), Quaternion.identity);
        }
    }
}
