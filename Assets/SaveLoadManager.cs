using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoadManager : MonoBehaviour
{
    private string ����������;
    public ResourceManager resourceManager;
    public TaskManager taskManager;

    private void Awake()
    {
        ���������� = Path.Combine(Application.persistentDataPath, "save.json");
        �������������(resourceManager, taskManager);
    }

    // ���������� ������
    public void �������������(ResourceManager resourceManager, TaskManager taskManager)
    {
        GameDataManager.GameData ������ = new GameDataManager.GameData
        {
            // ��������� �������
            ����� = resourceManager.�����,
            ����� = resourceManager.�����,
            ������ = resourceManager.������,
            ����� = resourceManager.�����,
            ������ = resourceManager.������,
            ������ = resourceManager.������,

            // ��������� �������� �������
            ������ = resourceManager.������,
            �������������� = resourceManager.��������������,
            ��������������������� = resourceManager.���������������������,
            ��������������������� = resourceManager.���������������������,
            ��������������������� = resourceManager.���������������������,
            ��������������������� = resourceManager.���������������������,
            ��������������������� = resourceManager.���������������������,
            �������������� = resourceManager.��������������,

            // ��������� ������� �������
            ����������� = taskManager.�����������
        };

        string json = JsonUtility.ToJson(������, true);
        File.WriteAllText(����������, json);
        Debug.Log("���� ���������!");
    }


    // �������� ������
    public void �������������(ResourceManager resourceManager, TaskManager taskManager)
    {
        if (File.Exists(����������))
        {
            string json = File.ReadAllText(����������);
            GameDataManager.GameData ������ = JsonUtility.FromJson<GameDataManager.GameData>(json);

            // ��������� �������
            resourceManager.����� = ������.�����;
            resourceManager.����� = ������.�����;
            resourceManager.������ = ������.������;
            resourceManager.����� = ������.�����;
            resourceManager.������ = ������.������;
            resourceManager.������ = ������.������;

            // ��������� �������� �������
            resourceManager.������ = ������.������;
            resourceManager.�������������� = ������.��������������;
            resourceManager.��������������������� = ������.���������������������;
            resourceManager.��������������������� = ������.���������������������;
            resourceManager.��������������������� = ������.���������������������;
            resourceManager.��������������������� = ������.���������������������;
            resourceManager.��������������������� = ������.���������������������;
            resourceManager.�������������� = ������.��������������;

            // ��������� ������� �������
            taskManager.����������� = ������.�����������;
            taskManager.�������������();

            // ��������� UI
            resourceManager.���������������();
            Debug.Log("���� ���������!");
        }
        else
        {
            Debug.Log("���� ���������� �� ������");
        }
    }

    // �������� ����������
    public void �����������������()
    {
        if (File.Exists(����������))
        {
            File.Delete(����������);
            Debug.Log("���������� �������!");
        }
    }

    private void OnApplicationQuit()
    {
        �������������(resourceManager, taskManager);  // ��������� ��� ������ �� ����
    }
}
