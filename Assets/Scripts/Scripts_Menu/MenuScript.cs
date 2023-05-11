using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   [SerializeField]
    private GameObject MenuPrincipal;

    [SerializeField]
    private GameObject Config;
    
    [SerializeField]
    private GameObject Creditos;
    
    
    void Start()
    {
        MenuPrin();
    }

    
   
 public void MenuPrin()
    {
        
        MenuPrincipal.SetActive(true);
        Config.SetActive(false);
        Creditos.SetActive(false);
    }
  
 public void Jogar()
    {
        SceneManager.LoadScene("Carta");
         Debug.Log("LOAD");
    }
 public void Configuracoes()
 {
        Config.SetActive(true);
        MenuPrincipal.SetActive(false);
        Creditos.SetActive(false);
 } 
  
 public void Credito()
    {
        
        Creditos.SetActive(true);
        Config.SetActive(false);
        MenuPrincipal.SetActive(false);
    }
        
 public void Sair()
    {
        
        Application.Quit();
        Debug.Log("Terminado");
    }
}
