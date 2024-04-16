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
        if (Input.GetKeyDown(KeyCode.W)) // ������� W ������
        {
            // �������� ���� ������� �� �������
            objectRenderer.material.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.S)) // ������� S ������
        {
            // �������� ���� ������� �� �����
            objectRenderer.material.color = Color.blue;
        }
    }
}
