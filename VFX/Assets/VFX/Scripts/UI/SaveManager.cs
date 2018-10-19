using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonManager
{
    public class SaveManager : MonoBehaviour
    {
        public static SaveManager instance = null; //Open Publicly to all Scripts can be access to.

        string PlayerName;
        string PointVie;
        string PositionX;

        //int

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(this.gameObject);
            }

            DontDestroyOnLoad(gameObject);
        }

        void Start()
        {
            PlayerPrefs.SetString("PlayerName", "Jay-CubScoutz");
            PlayerPrefs.GetString("PlayerName");
            Debug.Log(PlayerPrefs.GetString("PlayerName"));

            PlayerPrefs.SetInt("PointVie", 15);
            PlayerPrefs.GetInt("PointVie");
            Debug.Log(PlayerPrefs.GetInt("PointVie"));

            PlayerPrefs.SetFloat("PositionX", 0.15f);
            PlayerPrefs.GetFloat("PositionX");
            Debug.Log(PlayerPrefs.GetFloat("PositionX"));

            PlayerPrefs.DeleteAll();



        }

        void Update()
        {
            PlayerName = GetString("Player");
            PointVie = GetString("PointVie");
            PositionX = GetString("PositionX");

        }


        public static void SetString(string _PlayerName, string value)
        {
            PlayerPrefs.SetString(_PlayerName, value);
        }

        string GetString(string _playerName)
        {
            return PlayerPrefs.GetString(_playerName);
        }



        public static void SetInt(string key, int defaultValue)
        {
            PlayerPrefs.SetInt(key, defaultValue);
        }

        //string GetInt(string key)
        //{
        //    return PlayerPrefs.GetInt(key);
        //}



        public static void SetFloat(string key, float defaultValue)
        {
            PlayerPrefs.SetFloat(key, defaultValue);
        }

        //string SetFloat(string id)
        //{
        //    return PlayerPrefs.SetFloat(key);
        //}
    }
}
