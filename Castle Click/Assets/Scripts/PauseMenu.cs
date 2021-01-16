using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    // этот скрипт должен витель на кнопке паузы
    public GameObject PMenu; // это панель которая у тебя должна появится при паузе
   
    
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case ("PauseButton"): // имя кнопки при нажатии на которую появится панель
                PMenu.SetActive(true);
                Time.timeScale = 0;
                break;
        }
    }
}

