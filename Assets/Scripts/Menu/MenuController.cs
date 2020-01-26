using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static DataHolder;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Threading;

public class MenuController : MonoBehaviour
{
    /// <summary>
    /// поле ввода имени игрока
    /// </summary>
    //public InputField namefield;
    /// <summary>
    /// кнопка продолжения игры (неактивна в начале)
    /// </summary>
    public GameObject continuebutton;

    /// <summary>
    /// активация кнопки продолжения
    /// </summary>
    public void Awake()
    {
        if (continuebutton != null)
        {
            if (!IsContinueButtonActivated) continuebutton.SetActive(false);
            else continuebutton.SetActive(true);
        }
    }
    /// <summary>
    /// создание нового игрока
    /// </summary>
    public void PressNewGameButton()
    {
        SceneManager.LoadScene("Game");
    }

    /// <summary>
    /// начало игры из меню создания нового игрока
    /// </summary>
    //public void PressGoButton()
    //{
    //    DataHolderPlayerName = namefield.text;
    //    SceneManager.LoadScene("Game");
    //}

    /// <summary>
    /// продолжение игры из главного меню
    /// </summary>
    public void PressContinueButton()
    {
        SceneManager.LoadScene("Game");
    }
    
    /// <summary>
    /// выход из игры
    /// </summary>
    public void PressExitButton()
    {
        Application.Quit();
        Debug.Log("Exit pressed");
    }

    /// <summary>
    /// возврат в меню из игры
    /// </summary>
    public void PressToMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
