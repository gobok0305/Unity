using NUnit.Framework;
using System.Collections.Generic; //list �Ҷ�, �� ���������� ����� �� ���ڴ�
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    //alt ���ͷ� ���� ���ذ�
    //public List<int> listNumber = new List<int>();

    //ListNumber.Add();
    //List�� �����͸� �߰��ϴ� ��� (�Լ� = ���ó���� ����/�갡 �Լ��� ����� �����)
    //����Ʈ �ѹ��� �Լ��� ȣ���ϴ� ����

    //int = �迭 Ÿ�� //�����̸�
    //public int[] arrayNumber = new int[5]{1,2,3,4,5};
    //[5]= 5ĭ ����(count)  



    [SerializeField] 
    int level = 1;
    
    [SerializeField] 
    string characterName = "Unity";


    int number1 = 1;
    private int number2 = 2; 
    
    public int number3 = 3;

    [SerializeField] //= (�ʵ�) ����ȭ // deseialize: ����ȭ�� �����͸� ������� �ǵ���
    private int number4 = 4;

    [SerializeField] // �ø�������� ���� ���� ���� �Ʒ����� ��ġ�� ��� ����
    int number5 = 5;
    // ���ȼ����� ������, ����Ƽ������ ������ ������ ����� ������ �������� ��!
    //public�� ���־�����, ������ private ���� �ٲܼ��� ����
}   




    // void Start()
    //listNumber.Add(10);
    //listNumber.Add(50);
    //listNumber.Add(30);
    //listNumber.Add(40);
    //listNumber.Add(20);

    //listNumber[0]: ù��° ������
    //listNumber[2]: ����° ������


    //Debug.Log($"���� List�� �ִ� ������ �� :{listNumber.Count}");
    //                                    listNumber=5

    //Debug.Log($"���� List�� �ִ� ������ ������ :{listNumber[listNumber.Count-1]}");
    //                                     arrayNumber.Length
    //                                    array�� ������ ĭ��!





    // Debug.Log($"Array�� ù��° �� : {arrayNumber[0]}");
    // Debug.Log($"Array�� ����° �� : {arrayNumber[2]}");
    // Debug.Log($"Array�� ������° �� : {arrayNumber[5]}");
                                //($"Array�� ù��° �� : {arrayNumber[0]}")�� [0]=�ε���
                                     // ������ ������ 0������ ������!







/// �޸���
///public: �ٸ� Ŭ�������� ���� ���� + ����Ƽ �����Ϳ��� Ȯ�� ����
///private: ����(this)���� ���� / ����Ƽ �����Ϳ��� Ȯ�� x - public�� �Ⱥ����� private���� �ڵ����� ����
///������ ������ ���� ����!