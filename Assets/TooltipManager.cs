using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TooltipManager : MonoBehaviour
{
    public GameObject ДеревенскаяПодсказка;
    public GameObject ЛеснаяПодсказка;
    public TextMeshProUGUI ТекстЛеснойПодсказки;
    public TextMeshProUGUI ТекстДеревенскойПодсказки;

    //Показать лесную подсказку
    public void ПоказатьЛеснуюПодсказку(string message)
    {
        ЛеснаяПодсказка.SetActive(true);
        ТекстЛеснойПодсказки.text = message;
    }


    //Скрыть лесную подсказку
    public void СкрытьЛеснуюПодсказку()
    {
        ЛеснаяПодсказка.SetActive(false);
    }


    //Показать деревенскую подсказку
    public void ПоказатьДеревенскуюПодсказку(string message)
    {
        ДеревенскаяПодсказка.SetActive(true);
        ТекстДеревенскойПодсказки.text = message;
    }


    //Скрыть деревенскую подсказку
    public void СкрытьДеревенскуюПодсказку()
    {
        ДеревенскаяПодсказка.SetActive(false);
    }
}
