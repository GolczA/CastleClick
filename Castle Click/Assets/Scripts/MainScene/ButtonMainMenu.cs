using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMainMenu : MonoBehaviour
{
    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case ("Tutorial"):
                SceneManager.LoadScene("TutorialScene");
                break;
            case ("Start"):
                SceneManager.LoadScene("ChooseLevel");
                EnemyData.Load();
                
                break;
            case ("Option"):
                SceneManager.LoadScene("OptionScene");
                break;
            case ("Upgrade"):
                SceneManager.LoadScene("UpgradeScene");
                break;
            case ("Quit"):
                Application.Quit();
                break;
            case ("Reset"):
                EnemyData.ResetData();
                break;
        }
    }

}
