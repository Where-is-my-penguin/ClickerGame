using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPanelManager : MonoBehaviour
{
    public GameObject ����������;
    public GameObject �������������;
    public GameObject �������;

    // ����������
    public SaveLoadManager saveLoadManager;
    public ResourceManager resourceManager;
    public TaskManager taskManager;


    // ������� ����
    public void �����������()
    {
        ����������.SetActive(true);
        �������.SetActive(true);
        Time.timeScale = 0;         // ����� ����
        Debug.Log("���� �� �����!");
    }

    // ������� ����
    public void �����������()
    {
        ����������.SetActive(false);
        �������.SetActive(false);
        Time.timeScale = 1;         // ������������� ����
    }

    // ������� "���������"
    public void ����������������()
    {
        �������������.SetActive(true);
        ����������.SetActive(false);
    }

    // ������� "���������"
    public void ����������������()
    {
        ����������.SetActive(true);
        �������������.SetActive(false);
    }

    // ����� �� ����
    public void �����������()
    {
        Debug.Log("���� �������!"); // ��� ���������
        Application.Quit();         // ��� ������
    }

    public void �������������()
    {
        saveLoadManager.�������������(resourceManager, taskManager);
    }
    public void �������������()
    {
        saveLoadManager.�������������(resourceManager, taskManager);
    }
    public void ���������()
    {
        saveLoadManager.�����������������();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // ���������� �����
    }
}
