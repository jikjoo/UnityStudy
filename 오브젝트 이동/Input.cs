using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown){
            Debug.Log("플레이어가 아무키를 눌렀습니다.");
        }

        if(Input.anyKey){
            //Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        }

        // 키보드
        if(Input.GetKeyDown(KeyCode.Return)) // Enter 키
            Debug.Log("아이템을 구입하였습니다.");
        // KeyCode.Escape : ESC키
        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");
        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        // 마우스
        if(Input.GetMouseButtonDown(0))
            Debug.Log("왼쪽 클릭");
        if(Input.GetMouseButton(1))
            Debug.Log("오른쪽 버튼 누르는 중");

        //Edit -> Project Settings -> Input Manager에서 버튼 설정 가능
        if(Input.GetButtonDown("Jump")) // 모아서 할때는 GetButton 쓰고, Down은 잘 안써
            Debug.Log("점프!");

        if(Input.GetButton("Horizontal")){
            Debug.Log("횡 이동중..."
            + Input.GetAxis("Horizontal") // 1이나 -1로 점점 바뀌어짐. 가중치
            // Input.GetAxisRAW("Horizontal") // 바로 1이나 -1로
            );
        }
    }
}
