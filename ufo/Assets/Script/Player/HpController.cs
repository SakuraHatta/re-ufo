using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpController : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRender;
    [SerializeField]
    private Sprite sprite1;
    [SerializeField]
    private Sprite sprite2;
    [SerializeField]
    private Sprite sprite3;

    public int HpCount = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cannonChange();
    }

    private void cannonChange(){
        if (HpCount == 2){
            spriteRender.sprite = sprite2;
        }
        if (HpCount == 1){
            spriteRender.sprite = sprite3;
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "beam"){
            HpCount -= 1;
        }
    }
}
