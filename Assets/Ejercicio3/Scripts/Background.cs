using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Material backMaterial;
    
    void Start()
    {
        backMaterial = GetComponent<Renderer>().material;                                                             //Guarda el material del objeto
    }

    void Update()
    {
        backMaterial.mainTextureOffset = backMaterial.mainTextureOffset + Vector2.up * 0.5f * Time.deltaTime;        //mainTextureOffset es el offset de la textura
    }
}
