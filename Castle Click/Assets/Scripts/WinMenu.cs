using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public GameObject WinMen; // это панель которая у тебя должна появится при победе

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case ("RestartLevel"):
                SceneManager.LoadScene("GScene");
                WinMen.SetActive(false);
                
                break;
            case ("NextLevel"):
                SceneManager.LoadScene("GScene");
                EnemyData.levelcoefficent(EnemyData.levelUp);
                EnemyData.MLev(EnemyData.levelUp);
                

                break;
            case ("UpgradeWin"):
                SceneManager.LoadScene("Upgrade");
                break;
            case ("MainMenu"):
                SceneManager.LoadScene("MainMenu");
                Debug.Log(EnemyData.maxLevel.ToString() + "+ MaxLevel");
                break;
        }
    }
}
