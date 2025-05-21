using UnityEngine;
using NoeyA;
public class ProgammerB : MonoBehaviour
{
    //ProgammerA pA = new ProgammerA();
    //class를 활용해서 생성된 object(개체)
    //문제는 유니티에서 이런식으로 안씀
    //유니티에서 있는 스크립트는 데이터가 아니라 에셋이다!
    //걍 유니티에서 인스팩터로 스크립트 집어 넣으면 됨


    public ProgammerA pA;
    // progammera 클래스 타입을 받는 변수 pA선언

    void Start()
    {
        //pA.number1 = 10; 
        pA.number2 = 20; //얘만 public이라서 됨!
        //왜 유니티에서 null에러가 떴을까?

        //pA.number3 = 30;
        //pA.number4 = 40;
        //pA.number5 = 50;
    }


}
