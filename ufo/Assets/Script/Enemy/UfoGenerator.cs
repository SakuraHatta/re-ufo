using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject ufoPrefab;
    [SerializeField]
    private float span;
    private float time = 0;
    private Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ufoGenerate();
    }

    private void ufoGenerate(){
        time += Time.deltaTime;
        if(time > span){
            time = 0;
            pos.x = Random.Range(-7, 8);
            pos.y = 4.5f;
            Instantiate(ufoPrefab, pos, Quaternion.identity);
        }
    }
}