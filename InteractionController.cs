using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{
    public GameObject objectToChangeColor;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = objectToChangeColor.GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // Клавиша W нажата
        {
            // Изменяем цвет объекта на красный
            objectRenderer.material.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.S)) // Клавиша S нажата
        {
            // Изменяем цвет объекта на синий
            objectRenderer.material.color = Color.blue;
        }
    }
}
