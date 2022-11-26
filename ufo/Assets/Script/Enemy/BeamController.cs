using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamController : MonoBehaviour
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
        beamMove();
        beamDestroy();
    }

    private void beamMove(){
        pos.y -= speed * Time.deltaTime;
        this.transform.position = new Vector2(pos.x, pos.y);
    }

    private void beamDestroy(){
        if (pos.y < -4.0f){
            Destroy(this.gameObject);
        }
    }

    // cannonに当たったら消去
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "cannon"){
            Destroy(this.gameObject);
        }
    }

}
