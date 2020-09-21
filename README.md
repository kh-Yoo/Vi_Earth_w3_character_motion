# Vi_Earth_w3_character_motion
상명대 정보통신공학과 임베디드시스템 3조 Vi Earth - Unity 캐릭터 동작 구현

![KakaoTalk_20200921_190737772](https://user-images.githubusercontent.com/54584364/93771580-abed5200-fc58-11ea-90cb-ed30dff8a6ff.jpg)
[실행 영상](https://www.youtube.com/embed/9CgZFwSuNXo)

케릭터 동작
- Player 객체와 Enemy 객체를 생성하고 이미지를 불러와서 각 케릭터의 기본 이미지를 적용하였습니다
- 케릭터의 동작모션을 구현하기위해 상,하,좌,우 이동키를 누를때 생동감을 주기위해 
좌측 손발이 앞뒤로 간 사진 2개와 우측 손발이 앞뒤로 간 사진 2개, 일자로 서있는 사진 1개를 이용하여 이동하는 모션을 구현하였습니다.
- Enemy 객체는 사용자가 조종을 하지 않기 때문에 가만히 서있는 동작만이 구현되어있고 추후 Player객체와 상호작용 동작을 구현할 예정입니다.
- Assets 폴더 안에는 케릭터 동작 구현을 위한 폴더가 4개있으며
Animations 폴더, Prefabs폴더, Script폴더, Sprites폴더가 있고
Animations폴더는 Player 객체 상하좌우 이동 동작 사진에 Loop를 지정해서 속도감을 조절할수있고 다른 Action을 취할수있게 추가할수있습니다.
Prefabs폴더는 객체 기본 사진을 지정해두는것입니다
Script폴더는 C#코드를 이용하여 게임 진행과정에있어 초기값을 설정하고 동작 함수를 생성하여 케릭터의 좌표를 이동시키는 코드가 작성되어있습니다.
Sprites폴더는 케릭터 동작 사진을 pixel로 나누어서 저장되어있습니다.

아직은 배경이 미완성이지만 유니티의 Assets 폴더 안에 TilePalettes 폴더 안에 
원하는 이미지를 32x32 사이즈로 잘라서 유니티 타일 팔레트를 이용해서
원하는 이미지를 타일맵으로 하여금 하나씩 채워주면서 복수의 타일맵들이 합쳐져서
배경의 모습이 완성된다. 
