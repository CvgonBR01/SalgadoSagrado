using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MainMenu;
    
    public GameObject CreditsMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        MainmenuButton()
    }

    // Update is called once per frame
   
 public void MainMenuButton()
    {
        // Show Main Menu
        MainMenu.SetActive(true);
        CreditsMenu.SetActive(false);
    }
  
 public void PlayNowButton()
    {
        Debug.Log("LOAD");
        SceneManager.LoadScene("Level1");
    }
  
 public void CreditsButton()
    {
        // Show Credits Menu
        MainMenu.SetActive(false);
        CreditsMenu.SetActive(true);
    }
        
 public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}
