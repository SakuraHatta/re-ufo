using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    [SerializeField]
    private GameObject cannonSprite;
    [SerializeField]
    private Sprite secondSprite;
    [SerializeField]
    private Sprite thirdSprite;

    private int hpCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "beam"){
            
        }
    }
}
