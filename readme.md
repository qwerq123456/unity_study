유니티 강좌
===========

part 1 - 게임 오브젝트
--------------------

1. game tab : 카메라가 보고 있는 시점을 보여줌
   
2. scene tab : 여러 객체를 편집할 수 있는 공간
   
   *핸드 툴 (객체의 위치 이동)
   
   *십자가 텝 (내 위치 이동 가능)

   *회전 텝 (객체를 회전시킬 수 있음)

   *스케일 조절 텝 (객체의 크기 조절)

   *카메라 시점 조절 텝 (객체의 시야각? 조절)

   *위의 5가지 기능 종합 텝

3. asset store : 다른 기능 구매 가능
   
4. hierarchy : 만들고 있는 무대와 그 안의 객체
   
5. inspector : 현재 선택한 게임 오브젝트에 대한 상세 정보 표시 및 수정
    
    *tag

    *layer 

    *static


part 2 - 트랜스폼
----------------

1. Transform 

    *Position : 위치

    *Rotations : 회전

    *Scale : 크기

2. Unity 좌표계

    *x축 : 좌우

    *y축 : 상하

    *z축 : 정면

3. Script 이용하여 transform 수정하기

    1. Project - Assets 아래에 c#스크립트를 생성하면, 그것을 object에 적용 가능.

    2. Position 수정

        1. position 이용하여 Position 값 가져올 수 있음.
        
        2. Translate(vector) 메소드 이용하여 옮길 수 있음. 
    3. Rotations 수정
        
        1. eulerAngles 이용하여 Rotation의 값 불러올 수 있음. 

        2. 직접 Rotation값 처리하면 위험하므로 다른 벡터에 저장해놓고 처리하기

        3. Rotate 메소드 이용해서 처리

        4. Rotation Quaternion 사용하기. 

            - Quaternion의 값을 직접 계산하여 처리하기는 힘드므로 Euler 메소드 이용하여 처리. 2.와 같은 방법으로 처리

            - 직관적인 euler를 이용하지 않는 이유: euler값으로 처리할 경우 한축이 90이 될때 문제가 생김. 
    4. Scale 수정

        1. localScale 로 scale불러와서 처리

4. 여러가지 편리한 기능

    1. 정규화 벡터 : forward, up, right

    2. lookAt(target) : target을 보게 만듦

    3. RotateAround(target, vector, angle) : target을 vector축 기준으로 angle만큼 회전하게 만듦.

part 3 - 리지드 바디(Rigidbody)
--------

1. Rigidbody 컴포넌트
    - 중력, 관성, 저항등의 물리효과 부여 하는 컴포넌트
    - edit - project settings - physics 에서 설정 변환 가능
    - Inspector 창에서의 조절
        - Mass : 질량
        - Drag : 저항 (공기저항 느낌?)
        - Angular Drag : 회전값에 대한 저항
        - Use Gravity : 중력 적용 여부
        - Is kinemetic : 물리효과 on/off
        - Interpolate : 움직임 이상할때 보완 기능? 
        - collision Detection : 더 연속적이거나 더 세부적인 물리효과 적용가능
        - Constraints : 제약 사항(위치, 각도 고정)

    - method
        - MovePosition : 특정 위치로 옮김 
            - 연속적인 움직임으로 만드는게 아니라 플레이 중에쓰기보단 초기화 할때 쓰는게 좋을듯 하다. (태초마을?느낌으루다가)
        - AddForce : 특정 방향으로 힘을 가함 
            - 힘을 가하는 방향을 입력값으로 넣음
            - 질량 관성등의 물리값의 영향을 받음
        - AddTorque : 특정 방향으로 토크를 가함
            - 입력값은 회전 축
            - 질량 관성등의 물리값의 영향을 받음
        - AddExplosionForce : 폭발하는 힘을 가함
            - 폭발력, 폭발방향, 폭발 반경을 입력으로 넣어야함
            - 반경 안에선 같은 힘을 받는듯함
        - Move는 컴포넌트의 이동상태를 직접 변화시키고 Add는 물리효과를 작용시킨다.

part 4 - 컬라이더 (collider)
---------
1. 컬라이더
    - 물리적 충돌을 관리하는 컴포넌트
    - edit collider 
        - 충돌 범위를 설정
            - shift 누르고 하면 전체적으로 커짐
            - alt누르고 움직이면 반대방향도 커짐
        - 게임에서 피격범위? 같은것들이 보이는것과 조금 다른게 이런거 아닐까?

    - center
        - collider 의 중심을 바꿈
            - 무게중심이라 하면 되나?
    
    - material
        - Physics Material
            - 물리적 성질 부여
                - 탄성, 마찰등 부여
    
    - isTrigger
        - 충돌 감지
            - 충돌을 감지만 하고 물리적 효과는 무시한다
            - 진짜 트리거에 쓰는듯ㅋㅋ;
    
    - Method
        - Raycast : 레이저를 쏴서 collider와 만나는가?

    - OnTrigger
        - Start 나 Update처럼 MonoBehaviour안에 넣어서 사용
        - OnTriggerEnter() : 다른 collider 가 들어올때 실행
        - OnTriggerExit() : 다른 collider가 나갈때 실행
        - OnTriggerStay() : 다른 collider가 겹칠때
    - OnCollision
        - OnCollisionEnter() : 다른 collider와 충돌할때 실행
        - OnCollisionExit() : 다른 collider와 충돌 후에 실행
        - OnCollisionStay() : 서로 위치가 겹쳐졌을때 어떻게 될지 사용
            - 억지로 물체의 위치를 옮기다 겹쳐질 수 있음. 이때 문제가 생기지 않게 할때 사용
    - 따로 배운것
        - GetKeyDown : 누르고 있어도 한번으로 인식 GetKey는 누르고있으면 연속적으로 인식되는거와 다름
        - GetMouseButton : 마우스 버튼 입력 받음
            - 0: 좌, 1: 우
            - Down붙이면 누르고 있어도 한번만 인식

part 5 - 메쉬 렌더러
------
1. Mesh : 점과 선, 면의 집합체
    - 그래픽 이라고 생각하면 편할듯

2. Mesh Renderer
    - Materials
        - material만들고, 마우스로 드래그 해서 적용 가능
        - Albedo : 색 변경
        - Size : 적용하는 material 수
    
    - Lighting
        - Cast Shadows : 그림자 관련 설정
            - shadows only : 그림자만 나옴
                - 1인칭 게임 같은거 보면 내 캐릭 안보이고 장비만 보이는 것 같은 효과
                - 스타에서 클로킹이 딱 이기능일듯
        - Receive Shadows : 다른 물체의 그림자에 영향을 받음

    - Probe
        - 빛 관련 처리 다 할 수 있음. 주변 빛에 영향을 받게 세팅하는 부분이 있는데 잘 이해 안댐...ㅠ
        - Light Probes : 주변광 처리
        - Reflection Probes : 반사광 처리
        - Anchor Override : 다른 객체와 같은 효과를 받을 수 있게 해주는 기능

    - Additional Settings
        - Dynamic Occluded : 카메라가 볼때만 표시하기. 점점 물체가 많아지면 안보고 있는것을 처리하는게 비효율 적이기 때문에 쓰는 기능

