using JetBrains.Annotations;
using UnityEngine;

public class Studycomponent : MonoBehaviour
{
    // ť�� ���ӿ�����Ʈ�� �������� �ʹ�!
    GameObject obj;
    //������Ÿ��
    // ����Ƽ �����Ϳ��� �巡�׷� ���� �Ҵ� ����

    //�̸��� ���� �ٲ��ְ� �ʹ�!
    //����Ƽ���� ������ ���ڿ� ����
    public string changeName;


    void Start() //����Ƽ �����, 1���� ����
    {
        //�빮�ڷ� �����ϴ� �ֵ��� ��κ�  class�� ������
        obj = GameObject.Find("Main Camera");
                       //find(string �۾�); = ��ȣ�ȿ� �ִ� �̸��� �˻��ϴ� ��� (��ȯ����� ����)
        //���α׷��� �ڵ����� ã�Ƽ� �̸��� �˾Ƽ� �־���
        //������ �巡�� �ؼ� �־��� �ʿ� ����




        //���ӿ�����Ʈ�� �̸��� �����ϰ��� ��
        obj.name = changeName;
    }

    
}
