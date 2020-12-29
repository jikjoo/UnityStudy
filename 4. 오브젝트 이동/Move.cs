using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vec = new Vector3(0,0.1f,0); //벡터 값
        transform.Translate(vec);  // vec 만큼 이동함.
    }

    // Update is called once per frame
    void Update()
    {
        // 계속 이동
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0); //벡터 값
        transform.Translate(vec);  // vec 만큼 이동함.
    }
}
