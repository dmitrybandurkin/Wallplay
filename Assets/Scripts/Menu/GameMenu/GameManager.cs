using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DataHolder;
using static UnitManager;

public class GameManager : MonoBehaviour
{
    public Text slotsbox;
    public Text areabox;
    public Text currentnumberslotbox;

    public InputField playername;
    public Text namebox;
    public Text moneybox;



    /// <summary>
    /// номер юнита в слоте
    /// </summary>
    public int numberunit { get; set; }
    /// <summary>
    /// количество юнитов в слоте
    /// </summary>
    //int unitscount;
    /// <summary>
    /// номер слота
    /// </summary>
    public int numberslot { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        numberunit = 0;
        numberslot = 0;

        if (slotsunit[(ProductionPlaces)numberslot].Count == 0) slotsbox.text = "ПУСТО";
        else slotsbox.text = slotsunit[(ProductionPlaces)numberslot][0].GetName();

    }

    void Update()
    {
        DisplayGameInfo();
    }

    public void DisplayGameInfo()
    {
        moneybox.text = DataHolderPlayerMoney.ToString();
        namebox.text = DataHolderPlayerName;
        currentnumberslotbox.text = $"Слот #{(numberunit + 1)}/{MaxSlots}"; 
        if (slotsunit[(ProductionPlaces)numberslot].Count == 0) slotsbox.text = "Доступная площадь";
        else slotsbox.text = slotsunit[(ProductionPlaces)numberslot][numberunit].GetName();
        areabox.text = slots[(ProductionPlaces)numberslot];
    }

    public void PressButtonDown()
    {
        if (slotsunit[(ProductionPlaces)numberslot].Count != 0)
        {
            numberunit++;
            if (numberunit >= slotsunit[(ProductionPlaces)numberslot].Count) numberunit = 0;
        }
    }

    public void PressButtonUp()
    {
        if (slotsunit[(ProductionPlaces)numberslot].Count != 0)
        {
            numberunit--;
            if (numberunit < 0) numberunit = slotsunit[(ProductionPlaces)numberslot].Count - 1;
        }
    }

    public void PressButtonRight()
    {
        numberslot++;
        numberunit = 0;
        if (numberslot == (int)ProductionPlaces.END) numberslot = 0;
    }

    public void PressButtonLeft()
    {
        numberslot--;
        numberunit = 0;
        if (numberslot < 0) numberslot = (int)ProductionPlaces.END;
    }

    public void ConfirmPlayerButton()
    {
        DataHolderPlayerName = playername.text;
    }

    public void NextRoundButton()
    {
        if (slotsunit[ProductionPlaces.ProductionArea].Count > 0)
            {
                foreach (ProductionLine line in slotsunit[ProductionPlaces.ProductionArea])
                {
                DataHolderPlayerMoney += line.maxspeed * 10;
                }
            }

            
        else DataHolderPlayerMoney -= 100;
    }
}

#region Employers
public class TopManagement
{

}

public class Person
{
    public string PersonName { get; set; }
    public int PersonAge { get; set; }
    public Profession Prof { get; set; }
    public int Qualification { get; set; }
} 
#endregion
