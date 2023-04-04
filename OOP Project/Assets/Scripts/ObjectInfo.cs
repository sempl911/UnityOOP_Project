using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectInfo : MonoBehaviour
{
    public TextMeshProUGUI _aboutTxt;
    MeshRenderer objRenderer;
    Material meshMaterial;
    private Color objColor;

    private void Start()
    {
        objRenderer = GetComponent<MeshRenderer>();
        meshMaterial = objRenderer.material;
        objColor = meshMaterial.color;
    }

    private void Update()
    {

    }
  public virtual void ChangeColor(Color color)
    {
            meshMaterial.color = color;
    }
   public virtual void DisplayText(string txtAbout)
    {
            _aboutTxt.text = txtAbout;
    }
    private void OnMouseDown()
    {
        DisplayText("Hello, I am main object and main class");
        ChangeColor(Color.black);
    }
}
