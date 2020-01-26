using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DataHolder;
using UnityEngine.UI;

public class StatisticManager : MonoBehaviour
{

    public Text statisticbox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayStatisticInfo();
    }

    public void DisplayStatisticInfo()
    {
        statisticbox.text =
            $"Количество линий: {DataHolderUnitsAmount[ProductionPlaces.ProductionArea]}/{MaxSlots}\n" +
            $"Количество складов ГП: {DataHolderUnitsAmount[ProductionPlaces.WareHouse]}/{MaxSlots}\n" +
            $"Количество складов сырья: {DataHolderUnitsAmount[ProductionPlaces.Storage]}/{MaxSlots}\n" +
            $"Количество лабораторий: {DataHolderUnitsAmount[ProductionPlaces.ChemLab]}/{MaxSlots}\n" +
            $"Количество дизайнстудий: {DataHolderUnitsAmount[ProductionPlaces.DesignLab]}/{MaxSlots}\n" +
            $"Количество офисов: {DataHolderUnitsAmount[ProductionPlaces.Office]}/{MaxSlots}\n";
    }
}
