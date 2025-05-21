using UnityEngine;

public class Movement : MonoBehaviour
{  //클래스타입 클래스명
    public float moveSpeed; //속도변수 (속도조절을 위함) float = 기본 값 0f; (각 기본 값은 잘 기억하기)

    //void 반환타입 x 
    //영어 뒤 괄호 = 함수
    void Start() //유니티 에디터를 실행하면, 1변만 실행되는 함수 
    {   
        
        
        
        
        
        //this = 내가 만든 캐릭터(animal)
        //this.transform.position = this.transform.position + Vector3.forward;
    }   //현재 위치(= 캐릭터의 transform의 position)= 현재위치 + (0,0,1)

    
    void Update() // 매 프레임마다 실행 / 여러번 실행 
    {                                                                // 별은 곱하기
        this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
        //this.transform.position += Vector3.forward * moveSpeed; (위랑 같은 말)
        // 순차적으로 start() → update() 로 진행
    }
}
