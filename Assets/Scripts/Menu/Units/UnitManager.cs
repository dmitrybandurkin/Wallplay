using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DataHolder;
static public class UnitManager
{
    static public Dictionary<ProductionPlaces, string> slots;
    static public Dictionary<ProductionPlaces, List<SlotUnit>> slotsunit;
    public static Dictionary<ProductionPlaces, List<SlotUnit>> marketsunit;

    public static List<SlotUnit> buyline;
    public static List<SlotUnit> buywarehouse;
    public static List<SlotUnit> buystorage;
    public static List<SlotUnit> buyclab;
    public static List<SlotUnit> buydlab;
    public static List<SlotUnit> buyoffice;

    static public List<SlotUnit> PArea;
    static public List<SlotUnit> WHouse;
    static public List<SlotUnit> Stor;
    static public List<SlotUnit> Clab;
    static public List<SlotUnit> DLab;
    static public List<SlotUnit> Office;



    static UnitManager()
    {
        buyline = new List<SlotUnit>();
        buyline.Add(new ProductionLine("Stork", 25, 10000));
        buyline.Add(new ProductionLine("Olbrich", 30, 15000));
        buyline.Add(new ProductionLine("Manswille", 35, 20000));

        buywarehouse = new List<SlotUnit>();
        buywarehouse.Add(new WareHouse(Size.Large, 50000));
        buywarehouse.Add(new WareHouse(Size.Medium, 25000));
        buywarehouse.Add(new WareHouse(Size.Small, 5000));

        buystorage = new List<SlotUnit>();
        buystorage.Add(new Storage(Size.Large, 35000));
        buystorage.Add(new Storage(Size.Medium, 20000));
        buystorage.Add(new Storage(Size.Small, 10000));

        buyclab = new List<SlotUnit>();
        buyclab.Add(new CLab(50000));

        buydlab = new List<SlotUnit>();
        buydlab.Add(new DLab(50000));

        buyoffice = new List<SlotUnit>();
        buyoffice.Add(new Office(100000));


        marketsunit = new Dictionary<ProductionPlaces, List<SlotUnit>>();
        marketsunit.Add(ProductionPlaces.ProductionArea, buyline);
        marketsunit.Add(ProductionPlaces.WareHouse, buywarehouse);
        marketsunit.Add(ProductionPlaces.Storage, buystorage);
        marketsunit.Add(ProductionPlaces.ChemLab, buyclab);
        marketsunit.Add(ProductionPlaces.DesignLab, buydlab);
        marketsunit.Add(ProductionPlaces.Office, buyoffice);

        slots = new Dictionary<ProductionPlaces, string>();
        slots.Add(ProductionPlaces.ProductionArea, "Производственная линия");
        slots.Add(ProductionPlaces.WareHouse, "Склад готовой продукции");
        slots.Add(ProductionPlaces.Storage, "Склад сырья");
        slots.Add(ProductionPlaces.ChemLab, "Химическая лаборатория");
        slots.Add(ProductionPlaces.DesignLab, "Дизайнерская студия");
        slots.Add(ProductionPlaces.Office, "Офис продаж");

        slotsunit = new Dictionary<ProductionPlaces, List<SlotUnit>>();

        PArea = new List<SlotUnit>();
        WHouse = new List<SlotUnit>();
        Stor = new List<SlotUnit>();
        Clab = new List<SlotUnit>();
        DLab = new List<SlotUnit>();
        Office = new List<SlotUnit>();

        slotsunit.Add(ProductionPlaces.ProductionArea, PArea);
        slotsunit.Add(ProductionPlaces.WareHouse, WHouse);
        slotsunit.Add(ProductionPlaces.Storage, Stor);
        slotsunit.Add(ProductionPlaces.ChemLab, Clab);
        slotsunit.Add(ProductionPlaces.DesignLab, DLab);
        slotsunit.Add(ProductionPlaces.Office, Office);
    }
}

public class SlotUnit
{

    public string name;
    public int number;
    public int cost;
    public string description;
    public SlotUnit() { }
    public string GetName()
    {
        return name;
    }
}


public class ProductionLine : SlotUnit
{

    public int currentspeed;
    public int maxspeed;

    public ProductionLine(string manufacturer, int maxspeed, int cost)
    {
        this.name = manufacturer;
        this.maxspeed = maxspeed;
        this.cost = cost;
        this.description = $"Печатная линия производства {this.name}\n" +
            $"Максимальная скорость = {this.maxspeed}\n" +
            $"Стоимость = {this.cost}";
    }
}

public class WareHouse : SlotUnit
{
    public Size size;
    public WareHouse(Size size, int cost)
    {
        this.size = size;
        this.cost = cost;
        switch (size)
        {
            case Size.Large:
                this.name = "Большой склад";
                break;
            case Size.Medium:
                this.name = "Средний склад";
                break;
            case Size.Small:
                this.name = "Малый склад";
                break;
            default:
                break;
        }
        this.description = $"{this.name} вместимостью {(int)this.size} ед.\n" +
            $"Стоимость = {this.cost}";
    }
}

public class Storage : WareHouse
{
    public Storage(Size size, int cost) : base(size, cost) { }
}

public class CLab : SlotUnit
{
    public CLab(int cost)
    {
        this.cost = cost;
        this.name = "Химическая лаборатория";
        this.description = $"Химическая лаборатория\n" +
            $"Стоимость = {this.cost}";
    }
}

public class DLab : SlotUnit
{
    public DLab(int cost)
    {
        this.cost = cost;
        this.name = "Дизайнерская студия";
        this.description = $"Дизайнерская студия\n" +
            $"Стоимость = {this.cost}";
    }
}

public class Office : SlotUnit
{
    public Office(int cost)
    {
        this.cost = cost;
        this.name = "Офис";
        this.description = $"Офис\n" +
            $"Стоимость = {this.cost}";
    }
}