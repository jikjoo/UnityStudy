using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8,1.5f,0);
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update(){
        //1. MoveTowards 등속이동
        transform.position = Vector3.MoveTowards(transform.position,target,2f);

        //2. SmoothDamp 스무스 이동
        Vector3 velo = Vector3.up * 50;
        transform.position = Vector3.SmoothDamp(transform.position,
        target,ref velo, 0.1f);
        // ref는 참조 

        //3. Lerp : 선형 보간, 스무스보다 감속시간이 김                 0~1f
        transform.position = Vector3.Lerp(transform.position, target, 1f);
    
        //4. Slerp(구면 션형) 포물선 이동
        transform.position = Vector3.Slerp(transform.position,
        target, 0.0f);
    }
}
