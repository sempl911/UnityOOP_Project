using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InheritanceSphere : ObjectInfo
{
    public Color pressedColor;
    public string inheritanceTxt;

    MeshRenderer objRenderer;
    Material meshMaterial;
    private Color objColor;

    void Start()
    {
        objRenderer = GetComponent<MeshRenderer>();
        meshMaterial = objRenderer.material;
        objColor = meshMaterial.color;
    }

    void Update()
    {
        
    }
    public override void DisplayText(string txtAbout)
    {
       base.DisplayText(txtAbout);
    }
    public override void ChangeColor(Color color)
    {
        meshMaterial.color = color;
        //base.ChangeColor(color);
    }

    private void OnMouseDown()
    {
        DisplayText(inheritanceTxt);
        ChangeColor(pressedColor);
    }
}
