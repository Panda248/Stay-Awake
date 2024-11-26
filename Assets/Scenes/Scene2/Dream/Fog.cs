using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{

    public Shader fogShader;
    public Color fogColor;

    [Range(0.0f, 1.0f)]
    public float fogDensity;

    [Range(0.0f, 100.0f)]
    public float fogOffset;

    private Material fogMat;

    // Start is called before the first frame update
    void Start()
    {
        if (fogMat == null)
        {
            fogMat = new Material(fogShader);
            fogMat.hideFlags = HideFlags.HideAndDontSave;
        }

        Camera cam = GetComponent<Camera>();
        cam.depthTextureMode = cam.depthTextureMode | DepthTextureMode.Depth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        fogMat.SetVector("_FogColor", fogColor);
        fogMat.SetFloat("_FogDensity", fogDensity);
        fogMat.SetFloat("_FogOffset", fogOffset);
        Graphics.Blit(source, destination, fogMat);
    }
}
