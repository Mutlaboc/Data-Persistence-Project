using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;


public class MainUiHandler : MonoBehaviour
{

    // public string myName;
    //public string myText;
    // Start is called before the first frame update

    public void Start()
    {

    }


    void Update()
    {


    }


    


   /* public void MyFunction()
    {
       Debug.Log(iField.text);
       

    }*/
        // Кнопка Загрузка основной сцены
        public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Кнопка выхода
    public void Exit()
    {

#if UNITY_EDITOR

        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
