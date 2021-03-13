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