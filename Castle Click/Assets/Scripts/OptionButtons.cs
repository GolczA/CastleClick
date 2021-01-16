using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionButtons : MonoBehaviour
{
    public GameObject s_on, s_off;
    public Sprite blue, red;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Sound")
        {
            if (PlayerPrefs.GetString ("Sound") == "off")
            {
                s_off.SetActive(true);
                s_on.SetActive(false);
            }
            else 
            {
                s_on.SetActive(true);
                s_off.SetActive(false);
            }
        }
    
    }

    void OnMouseDawn()
    {
        GetComponent <SpriteRenderer> ().sprite = blue;  
    }
    void OnMauseUp()
    {
        GetComponent <SpriteRenderer>().sprite = red;
    }
    void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString ("Sound") != "off")
            GameObject.Find ("Click Audio").GetComponent <AudioSource> ().Play ();
        switch (gameObject.name)
        {
            case ("MainMenu"):
                    SceneManager.LoadScene("MainMenuScene");
                break;
            case ("PlayMarket"):
                    Application.OpenURL ("http://google.com");
                break;
            case ("Facebook"):
                    Application.OpenURL ("http://facebook.com");
                break;
            case ("Sound"):
                    if (PlayerPrefs.GetString ("Sound") != "off")
                    {
                        PlayerPrefs.SetString("Sound", "off");
                        s_off.SetActive(true);
                        s_on.SetActive(false);
                    }
                    else
                    {
                        PlayerPrefs.SetString("Sound", "on");
                        s_off.SetActive(false);
                        s_on.SetActive(true);                
                    }
                break;
        }
    }
}
