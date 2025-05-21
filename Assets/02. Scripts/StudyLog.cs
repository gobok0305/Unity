using UnityEngine;

public class StudyLog : MonoBehaviour
{   
    /// <summary>
    /// call= 함수실행 (= 호출)
    /// update() = 실행하기 전, 먼저 실행한다
    /// </summary>
    /// start = 1번만 실행
    // Start is called once before the first execution of Update after the MonoBehaviouris created
    void Start()
    {
        Debug.Log("Start 함수 실행"); // 일반적인 로그
        Debug.LogWarning("Start 함수 실행"); // 경고 로그 (인게임 내에 생긴 ㄴ제를 빨리 찾아서 해결 가능)
        Debug.LogError("Start 함수 실행"); // 에러 로그
        // void start, update는 유니티 상에서 런타입이 될때 실행되는 애들
        //객체상으로 존재해야 실행됨 (월드상의 오브젝트가 있어야 실행됨)
        // 코드가 오브젝트 안에 있어야 함
    }

    // Update is called once per frame
    /// <summary>
    /// 업데이트는 매 프레임마다 1번씩 실행된다
    /// </summary>
    void Update()
    {
        
    }
}