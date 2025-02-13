using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SwitchInterface : MonoBehaviour
{
    // ������ �� Canvas
    public GameObject ������Canvas;
    public GameObject �����������Canvas;

    // ������� ��������� (0 - MainCanvas, 1 - VillageCanvas)
    private int ���������������� = 0;

    public void �����������()
    {
        if (���������������� == 0)
        {
            // ������������� �� ��������� �������
            ������Canvas.SetActive(false);
            �����������Canvas.SetActive(true);
            ���������������� = 1;
        }
        else
        {
            // ������������� �� ��������� ����
            ������Canvas.SetActive(true);
            �����������Canvas.SetActive(false);
            ���������������� = 0;
        }
    }
}
