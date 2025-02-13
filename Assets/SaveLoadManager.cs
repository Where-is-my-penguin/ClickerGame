using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoadManager : MonoBehaviour
{
    private string путь ‘айлу;
    public ResourceManager resourceManager;
    public TaskManager taskManager;

    private void Awake()
    {
        путь ‘айлу = Path.Combine(Application.persistentDataPath, "save.json");
        «агрузить»гру(resourceManager, taskManager);
    }

    // —охранение данных
    public void —охранить»гру(ResourceManager resourceManager, TaskManager taskManager)
    {
        GameDataManager.GameData данные = new GameDataManager.GameData
        {
            // —охран€ем ресурсы
            ветки = resourceManager.ветки,
            камни = resourceManager.камни,
            солома = resourceManager.солома,
            брЄвна = resourceManager.брЄвна,
            топоры = resourceManager.топоры,
            лопаты = resourceManager.лопаты,

            // —охран€ем прогресс деревни
            жители = resourceManager.жители,
            свободныећеста = resourceManager.свободныећеста,
            свободные–абочиећеста = resourceManager.свободные–абочиећеста,
            рабочиећестаЋесопилки = resourceManager.рабочиећестаЋесопилки,
            рабочиећеста«емлекопа = resourceManager.рабочиећеста«емлекопа,
            зан€тыећестаЋесопилки = resourceManager.зан€тыећестаЋесопилки,
            зан€тыећеста«емлекопа = resourceManager.зан€тыећеста«емлекопа,
            жителиЌа–аботе = resourceManager.жителиЌа–аботе,

            // —охран€ем текущее задание
            этап«адани€ = taskManager.этап«адани€
        };

        string json = JsonUtility.ToJson(данные, true);
        File.WriteAllText(путь ‘айлу, json);
        Debug.Log("»гра сохранена!");
    }


    // «агрузка данных
    public void «агрузить»гру(ResourceManager resourceManager, TaskManager taskManager)
    {
        if (File.Exists(путь ‘айлу))
        {
            string json = File.ReadAllText(путь ‘айлу);
            GameDataManager.GameData данные = JsonUtility.FromJson<GameDataManager.GameData>(json);

            // «агружаем ресурсы
            resourceManager.ветки = данные.ветки;
            resourceManager.камни = данные.камни;
            resourceManager.солома = данные.солома;
            resourceManager.брЄвна = данные.брЄвна;
            resourceManager.топоры = данные.топоры;
            resourceManager.лопаты = данные.лопаты;

            // «агружаем прогресс деревни
            resourceManager.жители = данные.жители;
            resourceManager.свободныећеста = данные.свободныећеста;
            resourceManager.свободные–абочиећеста = данные.свободные–абочиећеста;
            resourceManager.рабочиећестаЋесопилки = данные.рабочиећестаЋесопилки;
            resourceManager.рабочиећеста«емлекопа = данные.рабочиећеста«емлекопа;
            resourceManager.зан€тыећестаЋесопилки = данные.зан€тыећестаЋесопилки;
            resourceManager.зан€тыећеста«емлекопа = данные.зан€тыећеста«емлекопа;
            resourceManager.жителиЌа–аботе = данные.жителиЌа–аботе;

            // «агружаем текущее задание
            taskManager.этап«адани€ = данные.этап«адани€;
            taskManager.ѕроверить÷ель();

            // ќбновл€ем UI
            resourceManager.ќбновить–есурсы();
            Debug.Log("»гра загружена!");
        }
        else
        {
            Debug.Log("‘айл сохранени€ не найден");
        }
    }

    // ”даление сохранени€
    public void ”далить—охранение()
    {
        if (File.Exists(путь ‘айлу))
        {
            File.Delete(путь ‘айлу);
            Debug.Log("—охранение удалено!");
        }
    }

    private void OnApplicationQuit()
    {
        —охранить»гру(resourceManager, taskManager);  // —охран€ем при выходе из игры
    }
}
