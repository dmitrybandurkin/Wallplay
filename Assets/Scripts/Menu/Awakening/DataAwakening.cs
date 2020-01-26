using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DataHolder;

public class DataAwakening : MonoBehaviour
{
    /// <summary>
    /// активация кнопки продолжения игры в главном меню - в момент входа в основное игровое меню
    /// </summary>
    void Awake()
    {
        IsContinueButtonActivated = true;
    }
}
