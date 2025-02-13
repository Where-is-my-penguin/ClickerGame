using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public ResourceManager resourceManager;

    public TextMeshProUGUI ������������;
    public int ����������� = 0;

    // ������ �����
    private string[] ������� = {
        "������� ����� ��� ������ �����",
        "������� ������ ��� �������������� ����(+2 ������ �� ������)",
        "������ 50 �����",
        "��������� ���",
        "��������� ���������",
        "��������� ������ ���������",
        "��������� 15 ����� ��� �������",
    };

    private void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
        ������������();
    }

    private void ������������()
    {
        if (����������� < �������.Length)
        {
            ������������.text = �������[�����������];
        }
        else
        {
            ������������.text = "��� ���� ���������!";
        }
    }

    private IEnumerator �������������()
    {
        ������������.text = "��������� ����";
        yield return new WaitForSeconds(2.5f);
        ������������.text = "�,��... �� ��...";
        yield return new WaitForSeconds(1.5f);
        �����������++;
        ������������();
    }

    public void �������������()
    {
        if (����������� == 0 && resourceManager.������ > 0)                 // ������� ����� ��� ������ �����
        {
            �����������++;
            ������������();
        }
        else if (����������� == 1 && resourceManager.������ > 0)            // ������� ������ ��� �������������� ����(+2 ������ �� ������)
        {
            �����������++;
            ������������();
        }
        else if (����������� == 2 && resourceManager.����� >= 50)          // ������ 50 ����� 
        {
            �����������++;
            ������������();
        }
        else if (����������� == 3 && resourceManager.�������������� >= 2)   // ��������� ���
        {
            StartCoroutine(�������������());
        }
        else if (����������� == 4)                                          // ������ ��������
        {
            �����������++;
            ������������();
        }
        else if (����������� == 5)                                          // ������ ���������
        {
            �����������++;
            ������������();
        }
        else if (����������� == 6 && resourceManager.�������������� >= 30)  // ��������� 15 ����� ��� �������"
        {
            �����������++;
            ������������();
        }
    }
    
}
