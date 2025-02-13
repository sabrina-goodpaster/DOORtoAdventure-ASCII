using System;


public class Weapon
{
    string weaponType ="";
    public string weaponName = "None";
    public int weapBonus = 0;
    int cost;

    public void CreateWeapons()
    {
        Weapon WoodenClub = new Weapon();
        WoodenClub.weaponType = "melee";
        WoodenClub.weapBonus = 1;
        WoodenClub.cost = 100;
        WoodenClub.weaponName = "Wooden Club";

        Weapon ShortSword = new Weapon();
        ShortSword.weaponType = "melee";
        ShortSword.weapBonus = 3;
        ShortSword.cost = 300;
        ShortSword.weaponName = "Short Sword";

        Weapon LongSword = new Weapon();
        LongSword.weaponType = "melee";
        LongSword.weapBonus = 6;
        LongSword.cost = 500;
        LongSword.weaponName = "Longsword +1";

        Weapon GreatSword = new Weapon();
        GreatSword.weaponType = "melee";
        GreatSword.weapBonus = 12;
        GreatSword.cost = 900;
        GreatSword.weaponName = "Greatsword +3";

        Weapon Slingshot = new Weapon();
        Slingshot.weaponType = "ranged";
        Slingshot.weapBonus = 1;
        Slingshot.cost = 100;
        Slingshot.weaponName = "Slingshot";

        Weapon Spear = new Weapon();
        Spear.weaponType = "ranged";
        Spear.weapBonus = 3;
        Spear.cost = 300;
        Spear.weaponName = "Spear";

        Weapon ShortBow = new Weapon();
        ShortBow.weaponType = "ranged";
        ShortBow.weapBonus = 3;
        ShortBow.cost = 500;
        ShortBow.weaponName = "Shortbow +1";

        Weapon GreatBow = new Weapon();
        GreatBow.weaponType = "ranged";
        GreatBow.weapBonus = 12;
        GreatBow.cost = 900;
        GreatBow.weaponName = "Greatbow +3";
        
        Weapon SmallWand = new Weapon();
        SmallWand.weaponType = "spell";
        SmallWand.weapBonus = 1;
        SmallWand.cost = 100;
        SmallWand.weaponName = "Small Wand";

        Weapon LargeWand = new Weapon();
        LargeWand.weaponType = "spell";
        LargeWand.weapBonus = 3;
        LargeWand.cost = 300;
        LargeWand.weaponName = "Large Wand";

        Weapon MagicRod = new Weapon();
        MagicRod.weaponType = "spell";
        MagicRod.weapBonus = 6;
        MagicRod.cost = 500;
        MagicRod.weaponName = "Magic Rod +1";

        Weapon MagicStaff = new Weapon();
        MagicStaff.weaponType = "spell";
        MagicStaff.weapBonus = 6;
        MagicStaff.cost = 900;
        MagicStaff.weaponName = "Magic Staff +3";
    }
}
