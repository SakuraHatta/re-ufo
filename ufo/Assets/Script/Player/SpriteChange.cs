using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRender;
    [SerializeField]
    private Sprite Sprite1;
    [SerializeField]
    private Sprite Sprite2;

    public int hpCount = 2;

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
        if (hpCount == 1){
            spriteRender.sprite = Sprite2;
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "beam"){
            hpCount -= 1;
        }
    }
}
