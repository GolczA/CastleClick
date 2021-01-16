using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausPan : MonoBehaviour
{
    // Этот скрипт должен висеть на понели и на кнопках внутри ее 
    public GameObject PMenu; // // это панель которая у тебя должна появится при паузе
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case ("Restart"):
                SceneManager.LoadScene("GScene");
                Time.timeScale = 1;
                break;
            case ("ReturnGame"):
                PMenu.SetActive(false);
                Time.timeScale = 1;
                break;
            case ("Upgrade"):
                SceneManager.LoadScene("Upgrade");
                break;
            case ("MainMenu"):
                SceneManager.LoadScene("MainMenu");
                break;
        }
    }
     
}
