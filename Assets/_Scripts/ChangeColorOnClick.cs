using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    private Renderer objRenderer;

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        objRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}

