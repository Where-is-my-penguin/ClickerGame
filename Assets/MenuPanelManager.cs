using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPanelManager : MonoBehaviour
{
    public GameObject панельћеню;
    public GameObject создателићеню;
    public GameObject фонћеню;

    // —охранение
    public SaveLoadManager saveLoadManager;
    public ResourceManager resourceManager;
    public TaskManager taskManager;


    // ќткрыть меню
    public void ќткрытьћеню()
    {
        панельћеню.SetActive(true);
        фонћеню.SetActive(true);
        Time.timeScale = 0;         // ѕауза игры
        Debug.Log("»гра на паузе!");
    }

    // «акрыть меню
    public void «акрытьћеню()
    {
        панельћеню.SetActive(false);
        фонћеню.SetActive(false);
        Time.timeScale = 1;         // ¬озобновление игры
    }

    // ќткрыть "—оздатели"
    public void ќткрыть—оздатели()
    {
        создателићеню.SetActive(true);
        панельћеню.SetActive(false);
    }

    // «акрыть "—оздатели"
    public void «акрыть—оздатели()
    {
        панельћеню.SetActive(true);
        создателићеню.SetActive(false);
    }

    // ¬ыход из игры
    public void ¬ыйти»з»гры()
    {
        Debug.Log("»гра закрыта!"); // ƒл€ редактора
        Application.Quit();         // ƒл€ сборки
    }

    public void —охранить»гру()
    {
        saveLoadManager.—охранить»гру(resourceManager, taskManager);
    }
    public void «агрузить»гру()
    {
        saveLoadManager.«агрузить»гру(resourceManager, taskManager);
    }
    public void Ќова€»гра()
    {
        saveLoadManager.”далить—охранение();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // ѕерезапуск сцены
    }
}
