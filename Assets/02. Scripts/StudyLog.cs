using UnityEngine;

public class StudyLog : MonoBehaviour
{   
    /// <summary>
    /// call= �Լ����� (= ȣ��)
    /// update() = �����ϱ� ��, ���� �����Ѵ�
    /// </summary>
    /// start = 1���� ����
    // Start is called once before the first execution of Update after the MonoBehaviouris created
    void Start()
    {
        Debug.Log("Start �Լ� ����"); // �Ϲ����� �α�
        Debug.LogWarning("Start �Լ� ����"); // ��� �α� (�ΰ��� ���� ���� ������ ���� ã�Ƽ� �ذ� ����)
        Debug.LogError("Start �Լ� ����"); // ���� �α�
        // void start, update�� ����Ƽ �󿡼� ��Ÿ���� �ɶ� ����Ǵ� �ֵ�
        //��ü������ �����ؾ� ����� (������� ������Ʈ�� �־�� �����)
        // �ڵ尡 ������Ʈ �ȿ� �־�� ��
    }

    // Update is called once per frame
    /// <summary>
    /// ������Ʈ�� �� �����Ӹ��� 1���� ����ȴ�
    /// </summary>
    void Update()
    {
        
    }
}