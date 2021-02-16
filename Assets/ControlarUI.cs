using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlarUI : MonoBehaviour
{
    public TMPro.TMP_Text helloSteamLabel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleHelloButton()
    {
        if(helloSteamLabel.enabled == true)
        {
            helloSteamLabel.enabled = false;
            Debug.Log("Deshabilitar etiqueta");
        }
        else
        {
            helloSteamLabel.enabled = true;
            Debug.Log("Habilitar etiqueta");
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("Scene02");
    }
}
