using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   [SerializeField]
    private GameObject MenuPrincipal;

    [SerializeField]
    private GameObject Comandos;
    
    [SerializeField]
    private GameObject Creditos;
    
    
    void Start()
    {
        MenuPrin();
    }

    
   
 public void MenuPrin()
    {
        
        MenuPrincipal.SetActive(true);
        Comandos.SetActive(false);
        Creditos.SetActive(false);
    }
  
 public void Jogar()
    {
        SceneManager.LoadScene("Carta");
         Debug.Log("LOAD");
    }

  
 public void Credito()
    {
        
        Creditos.SetActive(true);
        Comandos.SetActive(false);
        MenuPrincipal.SetActive(false);
    }

    public void Comando()
    {
        Creditos.SetActive(false);
        Comandos.SetActive(true);
        MenuPrincipal.SetActive(false);
    }
        
 public void Sair()
    {
        
        Application.Quit();
        Debug.Log("Terminado");
    }
}
