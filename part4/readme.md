Collider practice
-----
- 코드 설명
    - Start 에서 BoxCollider 불러옴
    - Update 에서 박스를 클릭하면 클릭한 위치로 박스를 움직이게 설정
        - GetMouseButton으로 클릭 받을 수 있음을 배움
        - camera 로부터 나온 ray라고 생각하고 짜는 과정들 배움
        - if(col.Raycast(ray, out hitinfo, 1000))    // 이거 왜 out hitinfo로 쓰는지 잘 모르겠음;; 
    - 박스가 다른 물체와 겹쳐있으면 다른 물체를 (0, 0, 0.01f)로 밀어냄
    - 다른물체가 박스에서 나가면 다른 물체의 position += (0, 2, 0);함
    - 박스가 충돌하면 박스의 position += (0, 2, 0); 함