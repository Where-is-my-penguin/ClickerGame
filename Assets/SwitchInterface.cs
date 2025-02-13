using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SwitchInterface : MonoBehaviour
{
    // Ссылки на Canvas
    public GameObject ЛеснойCanvas;
    public GameObject ДеревенскийCanvas;

    // Текущее состояние (0 - MainCanvas, 1 - VillageCanvas)
    private int ТекущееСостояние = 0;

    public void Переключить()
    {
        if (ТекущееСостояние == 0)
        {
            // Переключаемся на интерфейс деревни
            ЛеснойCanvas.SetActive(false);
            ДеревенскийCanvas.SetActive(true);
            ТекущееСостояние = 1;
        }
        else
        {
            // Переключаемся на интерфейс леса
            ЛеснойCanvas.SetActive(true);
            ДеревенскийCanvas.SetActive(false);
            ТекущееСостояние = 0;
        }
    }
}
