using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScriptCambioDeEscena : MonoBehaviour
{
    public void CambioDeEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
