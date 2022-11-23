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
    private int px;

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
            px = Random.Range(-8, 8);
            Instantiate(ufoPrefab, new Vector2(px, 4.3f), Quaternion.identity);
        }
    }
}