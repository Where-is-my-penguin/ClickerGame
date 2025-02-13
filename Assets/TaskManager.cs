using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskManager : MonoBehaviour
{
    public ResourceManager resourceManager;

    public TextMeshProUGUI ТекстЗадания;
    public int этапЗадания = 0;

    // Список целей
    private string[] задание = {
        "Создать топор для добычи брёвен",
        "Создать лопату для выкорчёвывания пней(+2 бревна за добычу)",
        "Добыть 50 брёвен",
        "Построить дом",
        "Построить лесопилку",
        "Построить хижину землекопа",
        "Построить 15 домов для жителей",
    };

    private void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
        ОбновитьЦель();
    }

    private void ОбновитьЦель()
    {
        if (этапЗадания < задание.Length)
        {
            ТекстЗадания.text = задание[этапЗадания];
        }
        else
        {
            ТекстЗадания.text = "Все цели выполнены!";
        }
    }

    private IEnumerator ПоказатьШутку()
    {
        ТекстЗадания.text = "Вырастить сына";
        yield return new WaitForSeconds(2.5f);
        ТекстЗадания.text = "А,ой... Не то...";
        yield return new WaitForSeconds(1.5f);
        этапЗадания++;
        ОбновитьЦель();
    }

    public void ПроверитьЦель()
    {
        if (этапЗадания == 0 && resourceManager.топоры > 0)                 // Создать топор для добычи брёвен
        {
            этапЗадания++;
            ОбновитьЦель();
        }
        else if (этапЗадания == 1 && resourceManager.лопаты > 0)            // Создать лопату для выкорчёвывания пней(+2 бревна за добычу)
        {
            этапЗадания++;
            ОбновитьЦель();
        }
        else if (этапЗадания == 2 && resourceManager.брёвна >= 50)          // Добыть 50 брёвен 
        {
            этапЗадания++;
            ОбновитьЦель();
        }
        else if (этапЗадания == 3 && resourceManager.свободныеМеста >= 2)   // Построить дом
        {
            StartCoroutine(ПоказатьШутку());
        }
        else if (этапЗадания == 4)                                          // Хижина лесоруба
        {
            этапЗадания++;
            ОбновитьЦель();
        }
        else if (этапЗадания == 5)                                          // Хижина землекопа
        {
            этапЗадания++;
            ОбновитьЦель();
        }
        else if (этапЗадания == 6 && resourceManager.свободныеМеста >= 30)  // Построить 15 домов для жителей"
        {
            этапЗадания++;
            ОбновитьЦель();
        }
    }
    
}
