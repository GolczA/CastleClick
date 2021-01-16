using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class DataEnem : MonoBehaviour
{

    public GameObject[] levelButtons = new GameObject[4];



    // У тебя есть этот скрипт, замени его на этот (кнопки на сцене ChooseLevel)

    public void Start()
    {
        Debug.Log(EnemyData.maxLevel.ToString() + "+ MAxLevel");
        // levelButtons = GameObject.FindGameObjectsWithTag("LButt"); // массив всех кнопок поставить тэг LButt
        // отключли коллайдеры всех конопок кроме 1 
        for (int i = 0; i <= levelButtons.Length - 1; i++)
        {
            if (i <= EnemyData.maxLevel)
            {
                levelButtons[i].GetComponent<BoxCollider2D>().enabled = true;
            }
            else
            {
                levelButtons[i].GetComponent<BoxCollider2D>().enabled = false;
            }
        }
       

    }
    
    public void OnMouseUpAsButton() 
    {
        switch(gameObject.name)
        {
            case "MainMenu": // назови кнопку перехода в главное меню так, или свое сюда поставь)
                    SceneManager.LoadScene("MainMenu"); // сдесь название твоей главное сцены
                break;
            case ("Upgrades"):
                    SceneManager.LoadScene("UpgradeScene");
                    break;
            case ("Level1"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(0);
                    EnemyData.levelUp = 0;

                break;
            case ("Level2"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(1);
                    EnemyData.levelUp = 1;
                break; 
            case ("Level3"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(2);
                    EnemyData.levelUp = 2;
                break;
            case ("Level4"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(3);
                    EnemyData.levelUp = 3;

                break;
            case ("Level5"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(4);

                break;
            case ("Level6"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(5);

                break;
            case ("Level7"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(6);

                break;
            case ("Level8"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(7);

                break;
            case ("Level9"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(9);

                break;
            case ("Level10"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(10);

                break;
            case ("Level11"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(11);

                break;
            case ("Level12"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(12);

                break;
            case ("Level13"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(13);

                break;
            case ("Level14"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(14);

                break;
            case ("Level15"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(15);

                break;
            case ("Level16"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(16);

                break;
            case ("Level17"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(17);

                break;
            case ("Level18"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(18);

                break;
            case ("Level19"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(19);

                break;
            case ("Level20"):
                    SceneManager.LoadScene("GScene");
                    EnemyData.levelcoefficent(20);

                break;

        }
    }

}
