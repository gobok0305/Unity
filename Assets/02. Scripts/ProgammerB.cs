using UnityEngine;
using NoeyA;
public class ProgammerB : MonoBehaviour
{
    //ProgammerA pA = new ProgammerA();
    //class�� Ȱ���ؼ� ������ object(��ü)
    //������ ����Ƽ���� �̷������� �Ⱦ�
    //����Ƽ���� �ִ� ��ũ��Ʈ�� �����Ͱ� �ƴ϶� �����̴�!
    //�� ����Ƽ���� �ν����ͷ� ��ũ��Ʈ ���� ������ ��


    public ProgammerA pA;
    // progammera Ŭ���� Ÿ���� �޴� ���� pA����

    void Start()
    {
        //pA.number1 = 10; 
        pA.number2 = 20; //�길 public�̶� ��!
        //�� ����Ƽ���� null������ ������?

        //pA.number3 = 30;
        //pA.number4 = 40;
        //pA.number5 = 50;
    }


}
