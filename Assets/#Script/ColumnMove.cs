using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{

    float makeTime;
    // Start is called before the first frame update
    void Start()
    {
        makeTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //만들어진 기둥을 5초후  삭제해서 기둥이 쌓이지 않게함
        if(Time.time - makeTime > 5f)
        Destroy(gameObject);
    }
}
