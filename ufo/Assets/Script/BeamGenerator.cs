using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamGenerator : MonoBehaviour
{
    /**
    * @brief ufoにアタッチ
    */

    [SerializeField]
    private GameObject beamPrefab;

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
        beamGenerate();
    }

    private void beamGenerate(){
        time += Time.deltaTime;
        if(time > span){
            time = 0;
            pos = this.transform.position;
            Instantiate(beamPrefab, pos, Quaternion.identity);
        }
    }
}
