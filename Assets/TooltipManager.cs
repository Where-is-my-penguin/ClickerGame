using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipManager : MonoBehaviour
{
    public GameObject ��������������������;
    public GameObject ���������������;
    public TextMeshProUGUI ��������������������;
    public TextMeshProUGUI �������������������������;

    //�������� ������ ���������
    public void �����������������������(string message)
    {
        ���������������.SetActive(true);
        ��������������������.text = message;
    }


    //������ ������ ���������
    public void ���������������������()
    {
        ���������������.SetActive(false);
    }


    //�������� ����������� ���������
    public void ����������������������������(string message)
    {
        ��������������������.SetActive(true);
        �������������������������.text = message;
    }


    //������ ����������� ���������
    public void ��������������������������()
    {
        ��������������������.SetActive(false);
    }
}
