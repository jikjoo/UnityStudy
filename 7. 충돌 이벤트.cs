using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "MyCube"){
            mat.color = new Color(0,0,0); // 검정색.  (1,1,1)은 하얀색
        }
    }
    // trigger는 물리효과 적용 X. 충돌 일어나지 않음
    private void OnTriggerStay(Collider other) {
        if(other.gameObject.name == "Cylinder"){
            Debug.Log("trigger OtherBall");
        }
    }
}
