using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Comandos(string escena)
    {
        SceneManager.LoadScene(escena);
    }
    public void Salir() 
    {
        Application.Quit();
    }
}
