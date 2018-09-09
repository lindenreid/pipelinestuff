using UnityEngine;

[ExecuteInEditMode]
public class CustomGlowObj : MonoBehaviour
{
    public Material glowMaterial;

    public void OnEnable()
    {
        CustomGlowSystem.instance.Add(this);
    }

    public void Start()
    {
        CustomGlowSystem.instance.Add(this);
    }

    public void OnDisable()
    {
        CustomGlowSystem.instance.Remove(this);
    }

}