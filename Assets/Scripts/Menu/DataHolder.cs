using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataHolder
{
    public enum ProductionPlaces
    {
        ProductionArea,
        WareHouse,
        Storage,
        ChemLab,
        DesignLab,
        Office,
        END
    }

    public enum Profession
    {
        HR,
        Utility,
        Purchasy,
        Supply,
        Production,
        RND,
        Designers,
        Security,
        Marketing,
        Sails,
        Finance,
        END
    }

    public enum Size
    {
        Zero,
        Small = 500,
        Medium = 2000,
        Large = 5000
    }

    /// <summary>
    /// имя игрока
    /// </summary>
    public static string DataHolderPlayerName { get; set; }

    /// <summary>
    /// деньги игрока
    /// </summary>
    public static int DataHolderPlayerMoney { get; set; }

    public static readonly int DataHolderPlayerMoneyDefault;

    public static Dictionary<ProductionPlaces, int> DataHolderUnitsAmount;

    public static readonly int MaxSlots=5;
    /// <summary>
    /// активация кнопки продолжения
    /// </summary>
    /// 

    public static bool IsContinueButtonActivated { get; set; }

    static DataHolder()
    {
        DataHolderUnitsAmount = new Dictionary<ProductionPlaces, int>();

        DataHolderPlayerMoneyDefault = 100000;
        DataHolderPlayerMoney = 100000;

        DataHolderUnitsAmount.Add(ProductionPlaces.ProductionArea, 0);
        DataHolderUnitsAmount.Add(ProductionPlaces.WareHouse, 0);
        DataHolderUnitsAmount.Add(ProductionPlaces.Storage, 0);
        DataHolderUnitsAmount.Add(ProductionPlaces.ChemLab, 0);
        DataHolderUnitsAmount.Add(ProductionPlaces.DesignLab, 0);
        DataHolderUnitsAmount.Add(ProductionPlaces.Office, 0);
    }
}
