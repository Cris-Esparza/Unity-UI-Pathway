using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapsuleColor : MonoBehaviour
{
    public MeshRenderer capsule;
    public Slider red;


    public void OnEdit()
    {
        Color color = capsule.material.color;
        color.r = red.value;
        capsule.material.color = color;
        capsule.material.SetColor("_EmissionColor", color);
    }
}
