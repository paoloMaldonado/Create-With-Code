using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpGreen : MonoBehaviour
{
    public GameObject cube;
    private MeshRenderer Renderer;
    private float speed = 0.3f;
    private Material material;

    void Start()
    {
        Renderer = cube.GetComponent<MeshRenderer>();
        material = Renderer.material;
    }

    void Update()
    {
        material.color = Color.Lerp(Color.clear, Color.green, Mathf.PingPong(Time.time * speed, 1));
    }
}
