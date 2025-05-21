using JetBrains.Annotations;
using UnityEngine;

public class Studycomponent : MonoBehaviour
{
    // 큐브 게임오브젝트를 가져오고 싶다!
    GameObject obj;
    //데이터타입
    // 유니티 에디터에서 드래그로 직접 할당 가능

    //이름을 자주 바꿔주고 싶다!
    //유니티에서 설정할 문자열 변수
    public string changeName;


    void Start() //유니티 실행시, 1번만 실행
    {
        //대문자로 시작하는 애들은 대부분  class와 유사함
        obj = GameObject.Find("Main Camera");
                       //find(string 글씨); = 괄호안에 있는 이름을 검색하는 기능 (반환기능이 있음)
        //프로그램이 자동으로 찾아서 이름을 알아서 넣어줌
        //일일히 드래그 해서 넣어줄 필요 없음




        //게임오브젝트의 이름을 변경하고자 함
        obj.name = changeName;
    }

    
}
