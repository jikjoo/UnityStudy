# 오브젝트 이동
## Input.cs
    Input에는 Down, 누르기 있기, Up 3가지 있음.
    GetKey, GetMouseButton, GetButton로 입력
    Edit -> Project Settings -> Input Manager에서 버튼 설정 가능
    Input.GetAxis로 축 입력값 확인
    
## Move.cs
    Object는 변수 transform을 항상 갖고 있음.
    Object랑 transform은 1대1 대응함.
    Vector3 : X,Y,Z 3차원
    Vector2 : 2차원
    
    카메라까지 같이 움직이려면 
    Main Camera에 Move 스크립트 넣기.
