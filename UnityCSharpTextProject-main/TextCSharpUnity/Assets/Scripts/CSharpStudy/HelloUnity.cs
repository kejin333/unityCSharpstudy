using UnityEngine;
using TMPro;

public class HelloUnity : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;  // ������ Ÿ������ �𸣰����� ������ ����ϱ� ���ؼ� text�̸��� ������ �����ϰڴ�.

    int damage = 100;           // ���� ��
    float time = 30.5f;         // �Ǽ� ��
    string name = "�̼���";     // ���ڿ� ��

    private void Start() // ���� ���� �� �ѹ��� ���� �Ѵ�.
    {
        Debug.Log("�������� ��" + damage);   
        Debug.Log("�ð��� ��" + time);      
        Debug.Log("�̸�" +name);


        text.text = string.Format($"Only{damage} English{time} is visible : �����̴� ?"); // ����� ������ ����.
    }


}
