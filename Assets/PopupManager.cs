using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPrefab;  // ������ ���������
    public Transform popupPatern;   // �������� ��� ��������� (�������� Canvas)

    public void ShowPopup(string message)
    {

        // ������ ����� ��������� ��� �������
        GameObject popup = Instantiate(popupPrefab, popupPatern);

        // ������������� ����� ���������
        TextMeshProUGUI popupText = popup.GetComponentInChildren<TextMeshProUGUI>();
        popupText.text = message;

        // ���������� ��������� � ���������
        StartCoroutine(FadeOutAndDestroy(popup));
    }

    private IEnumerator FadeOutAndDestroy(GameObject popup)
    {
        CanvasGroup canvasGroup = popup.GetComponent<CanvasGroup>();

        // ���������� ���������
        canvasGroup.alpha = 1;

        // ��� 2 ������� ����� ������� ������������
        yield return new WaitForSeconds(2f);

        // ������� ������������ 
        float fadeDuration = 1f; //����� ������������ 
        for (float t = 0; t < fadeDuration; t += Time.deltaTime)
        {
            canvasGroup.alpha = 1 - (t / fadeDuration);
            yield return null;
        }

        // ������ ������������
        canvasGroup.alpha = 0;

        // ������� ������
        Destroy(popup);
    }
}
