using System;


public class Armor
{
    public int armorBonus = 0;
    int cost;
    public string armorName = "None";

    public void CreateArmor()
    {
        Armor Leather = new Armor();
        Leather.armorBonus = 1;
        Leather.cost = 100;
        Leather.armorName = "Leather";

        Armor LightChain = new Armor();
        LightChain.armorBonus = 3;
        LightChain.cost = 300;
        LightChain.armorName = "Chain Tunic";

        Armor Breastplate= new Armor();
        Breastplate.armorBonus = 6;
        Breastplate.cost = 500;
        Breastplate.armorName = "Steel Breastplate";

        Armor FullPlate = new Armor();
        FullPlate.armorBonus = 12;
        FullPlate.cost = 900;
        FullPlate.armorName = "Full Steel Plate";

    }
}
