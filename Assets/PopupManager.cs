using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPrefab;  // Префаб подсказки
    public Transform popupPatern;   // Родитель для подсказок (например Canvas)

    public void ShowPopup(string message)
    {

        // Создаём новую подсказку для префаба
        GameObject popup = Instantiate(popupPrefab, popupPatern);

        // Устанавливаем текст подсказки
        TextMeshProUGUI popupText = popup.GetComponentInChildren<TextMeshProUGUI>();
        popupText.text = message;

        // Показываем подсказку с анимацией
        StartCoroutine(FadeOutAndDestroy(popup));
    }

    private IEnumerator FadeOutAndDestroy(GameObject popup)
    {
        CanvasGroup canvasGroup = popup.GetComponent<CanvasGroup>();

        // Показываем подсказку
        canvasGroup.alpha = 1;

        // Ждём 2 секунды перед началом исчезновения
        yield return new WaitForSeconds(2f);

        // Плавное исчезновение 
        float fadeDuration = 1f; //Время исчезновения 
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            canvasGroup.alpha = 1 - (t / fadeDuration);
            yield return null;
        }

        // Полное исчезновение
        canvasGroup.alpha = 0;

        // Удаляем объект
        Destroy(popup);
    }
}
