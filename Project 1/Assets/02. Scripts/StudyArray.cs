using NUnit.Framework;
using System.Collections.Generic; //list 할때, 이 지역변수를 끌어다 좀 쓰겠다
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    //alt 엔터로 빨간 줄해결
    //public List<int> listNumber = new List<int>();

    //ListNumber.Add();
    //List에 데이터를 추가하는 기능 (함수 = 기능처리의 단위/얘가 함수랑 기능이 비슷해)
    //리스트 넘버에 함수를 호출하는 내용

    //int = 배열 타입 //변수이름
    //public int[] arrayNumber = new int[5]{1,2,3,4,5};
    //[5]= 5칸 생성(count)  



    [SerializeField] 
    int level = 1;
    
    [SerializeField] 
    string characterName = "Unity";


    int number1 = 1;
    private int number2 = 2; 
    
    public int number3 = 3;

    [SerializeField] //= (필드) 직렬화 // deseialize: 직렬화된 데이터를 원래대로 되돌림
    private int number4 = 4;

    [SerializeField] // 시리얼라이즈 옆에 붙혀 쓸지 아래쓸지 위치는 상관 없음
    int number5 = 5;
    // 보안수준이 높지만, 유니티에서만 열도록 권한을 허용한 것으로 설정해준 것!
    //public을 자주쓰지만, 간간히 private 으로 바꿀수도 있음
}   




    // void Start()
    //listNumber.Add(10);
    //listNumber.Add(50);
    //listNumber.Add(30);
    //listNumber.Add(40);
    //listNumber.Add(20);

    //listNumber[0]: 첫번째 데이터
    //listNumber[2]: 세번째 데이터


    //Debug.Log($"현재 List에 있는 데이터 수 :{listNumber.Count}");
    //                                    listNumber=5

    //Debug.Log($"현재 List에 있는 마지막 데이터 :{listNumber[listNumber.Count-1]}");
    //                                     arrayNumber.Length
    //                                    array는 나열된 칸들!





    // Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
    // Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
    // Debug.Log($"Array의 여섯번째 값 : {arrayNumber[5]}");
                                //($"Array의 첫번째 값 : {arrayNumber[0]}")의 [0]=인덱서
                                     // 순서는 부조건 0번부터 시작함!







/// 메모장
///public: 다른 클래스에서 접근 가능 + 유니티 에디터에서 확인 가능
///private: 나만(this)접근 가능 / 유니티 에디터에서 확인 x - public을 안붙히면 private으로 자동으로 잡힘
///적을지 말지는 취향 차이!