using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private Material material;

    void Start()
    {
        material = Renderer.material;
        material.color = Color.clear;
    }

    void Update()
    {
        transform.Rotate(0.0f, 10.0f * Time.deltaTime, 0.0f);
    }
}
