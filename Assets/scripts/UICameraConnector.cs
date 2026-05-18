using UnityEngine;

public class UICameraConnector : MonoBehaviour
{
    private Canvas canvas;

    void Start()
    {
        canvas = GetComponent<Canvas>();
        if (canvas == null)
        {
            Debug.LogError("UICameraConnector: на объекте нет компонента Canvas!");
            return;
        }

        // Ищем камеру с тегом "MainCamera" (из Bootstrapper)
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            canvas.worldCamera = mainCamera;
            Debug.Log("Canvas успешно привязан к Main Camera из Bootstrapper.");
        }
        else
        {
            Debug.LogError("Main Camera не найдена! Убедитесь, что сцена Bootstrapper загружена и её камера имеет тег MainCamera.");
        }
    }
}