using UnityEngine;

public class Movement : MonoBehaviour
{  //Ŭ����Ÿ�� Ŭ������
    public float moveSpeed; //�ӵ����� (�ӵ������� ����) float = �⺻ �� 0f; (�� �⺻ ���� �� ����ϱ�)

    //void ��ȯŸ�� x 
    //���� �� ��ȣ = �Լ�
    void Start() //����Ƽ �����͸� �����ϸ�, 1���� ����Ǵ� �Լ� 
    {   
        
        
        
        
        
        //this = ���� ���� ĳ����(animal)
        //this.transform.position = this.transform.position + Vector3.forward;
    }   //���� ��ġ(= ĳ������ transform�� position)= ������ġ + (0,0,1)

    
    void Update() // �� �����Ӹ��� ���� / ������ ���� 
    {                                                                // ���� ���ϱ�
        this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
        //this.transform.position += Vector3.forward * moveSpeed; (���� ���� ��)
        // ���������� start() �� update() �� ����
    }
}
