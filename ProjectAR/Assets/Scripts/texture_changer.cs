using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class texture_changer : MonoBehaviour
{
    //codes 
    

    public int text_code = 1;

    public GameObject cube;
    
    public Texture[] textures;

    private Renderer cubeRenderer;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.mainTexture = textures[text_code];
        
    }   
}
