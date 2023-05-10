using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject MenuPrincipal;

    [SerializeField]
    private GameObject Config;
    
    [SerializeField]
    private GameObject Creditos;
    
    //Start is called before the first frame update
    void Start()
    {
        MenuPrin();
    }

    //Update is called once per frame
   
 public void MenuPrin()
    {
        // Show Main Menu
        MenuPrincipal.SetActive(true);
        Config.SetActive(false);
        Creditos.SetActive(false);
    }
  
 public void Jogar()
    {
        SceneManager.LoadScene("Level1");
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
        //Show Credits Menu
        Creditos.SetActive(true);
        Config.SetActive(false);
        MenuPrincipal.SetActive(false);
    }
        
 public void Sair()
    {
        //Quit Game
        //Application.Quit();
        Debug.Log("Terminado");
    }
}
