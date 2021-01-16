using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    // это статистический скрипт должен так работать , если не зайдет накинь на игровую сцену (на фон)
    public static int levelUp;
    // сколько левелов сейчас открыто 
    public static int maxLevel; 
    
    // public static bool[] LevUp = new bool[20];
    public static float[] ED = new float[3]; // урона патрона, жизнь замка, частота выстрела 


    // ИГРОК
    public static float plDamage = 100f;
    public static bool check; // проверка был ли уровень логически завершен, победой или поражением
    public void Awake()
    {
        check = false;
        Save();
    }
   
    public static float[] levelcoefficent(int coefficentlevel)
    {
        ED[0] = 1 + (coefficentlevel * 0.5f); // Урон патрона 
        ED[1] = 100f + ((coefficentlevel / 5) * 100f); // жизни замка
        ED[2] = 0.3f - ((coefficentlevel / 10) * 0.05f); // частота выстрела
        return ED;
    }
    public static void Save()
    {
        string key = "MaxLevel";
        PlayerPrefs.SetInt(key, maxLevel);
        PlayerPrefs.Save();
    }
    public static void Load()
    {
        string key = "MaxLevel";
        if (PlayerPrefs.HasKey(key))
        {
            maxLevel = PlayerPrefs.GetInt(key);
        }
    }
    public static void ResetData()
    {
        PlayerPrefs.DeleteAll();
        maxLevel = 0; 
    }
    public static int MLev( int le)  // запись максимального уровня
    {
        if (maxLevel <= le)
        {
            maxLevel = le;
        }

        
        return maxLevel; 
    }




}
