using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SimpleUI : MonoBehaviour
{
    public TextMeshProUGUI DdayText;
    public TextMeshProUGUI DdayTextValue;
    public TextMeshProUGUI ItemInfoText;
    public TextMeshProUGUI ResultText;

    int currentDday = 1;
    string curretItem = "�ռҵ�";
    int result = 1000;

    // Start is called before the first frame update
    void Start()                      // ������ �����ϰ� �ѹ��� ����Ǵ� �̺�Ʈ �Լ�
    {
        NextDday(9);
        DdayText.text = "D-day" + " " + currentDday;
        DdayTextValue.text = "1";
        ItemInfoText.text = curretItem;
        ResultText.text = "���� ��� " + result + "��";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextDday(int time)
    {
        currentDday = currentDday + time;
    } 
}
