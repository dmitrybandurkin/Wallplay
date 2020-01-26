using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DataHolder;
using UnityEngine.UI;
using static UnitManager;

public class CapacityManager : MonoBehaviour
{
    public Text buyslotbox;
    public Text buyunitbox;
    public Text descriptionbox;

    public int numberslot { get; set; }
    public int numberunit { get; set; }
    int unitscount;

    // Start is called before the first frame update
    void Start()
    {
        numberslot = 0;
        numberunit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayCapacityInfo();
    }

    void DisplayCapacityInfo()
    {
        buyslotbox.text = slots[(ProductionPlaces)numberslot];
        buyunitbox.text = marketsunit[(ProductionPlaces)numberslot][numberunit].GetName();
        descriptionbox.text = marketsunit[(ProductionPlaces)numberslot][numberunit].description;
    }

    public void RightSlotButton()
    {
        numberslot++;
        numberunit = 0;
        if (numberslot == (int)ProductionPlaces.END) numberslot = 0;
    }

    public void LeftSlotButton()
    {
        numberslot--;
        numberunit = 0;
        if (numberslot == (int)ProductionPlaces.END) numberslot = 0;
    }

    public void RightUnitButton()
    {
        numberunit++;
        if (numberunit >= marketsunit[(ProductionPlaces)numberslot].Count) numberunit = 0;
    }

    public void LeftUnitButton()
    {
        numberunit--;
        if (numberunit < 0) numberunit = marketsunit[(ProductionPlaces)numberslot].Count - 1;
    }

    public void BuyUnitButton()
    {
        if (slotsunit[(ProductionPlaces)numberslot].Count < MaxSlots && DataHolderPlayerMoney >= marketsunit[(ProductionPlaces)numberslot][numberunit].cost)
        {
            slotsunit[(ProductionPlaces)numberslot].Add(marketsunit[(ProductionPlaces)numberslot][numberunit]);
            DataHolderUnitsAmount[(ProductionPlaces)numberslot] = slotsunit[(ProductionPlaces)numberslot].Count;
            DataHolderPlayerMoney -= marketsunit[(ProductionPlaces)numberslot][numberunit].cost;
        }
    }
}
