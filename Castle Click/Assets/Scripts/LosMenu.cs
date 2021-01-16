using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LosMenu : MonoBehaviour
{
    public GameObject LoseMenu;
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case ("RestartLevel"):
                    SceneManager.LoadScene("GScene");
                    LoseMenu.SetActive(false);
                break;
            case ("ChooseLevel"):
                    SceneManager.LoadScene("ChooseLevel");
                break;
            case ("Upgrade"):
                    SceneManager.LoadScene("Upgrade");
                break;
            case ("MainMenuLose"):
                    SceneManager.LoadScene("MainMenu");
                break;
        }
    }
}
