using System;
using System.Runtime.ConstrainedExecution;

public class Weapon
{
    string weaponType ="";
    int weapBonus, cost;

    public void CreateWeapons()
    {
        Weapon WoodenClub = new Weapon();
        WoodenClub.weaponType = "melee";
        WoodenClub.weapBonus = 1;
        WoodenClub.cost = 100;

        Weapon ShortSword = new Weapon();
        ShortSword.weaponType = "melee";
        ShortSword.weapBonus = 3;
        ShortSword.cost = 300;

        Weapon LongSword = new Weapon();
        LongSword.weaponType = "melee";
        LongSword.weapBonus = 6;
        LongSword.cost = 500;

        Weapon GreatSword = new Weapon();
        GreatSword.weaponType = "melee";
        GreatSword.weapBonus = 12;
        GreatSword.cost = 900;

        Weapon Slingshot = new Weapon();
        Slingshot.weaponType = "ranged";
        Slingshot.weapBonus = 1;
        Slingshot.cost = 100;

        Weapon ShortBow = new Weapon();
        ShortBow.weaponType = "ranged";
        ShortBow.weapBonus = 3;
        ShortBow.cost = 300;

        Weapon Crossbow = new Weapon();
        Crossbow.weaponType = "ranged";
        Crossbow.weapBonus = 6;
        Crossbow.cost = 500;

        Weapon GreatBow = new Weapon();
        GreatBow.weaponType = "ranged";
        GreatBow.weapBonus = 12;
        GreatBow.cost = 900; 
        
        Weapon SmallWand = new Weapon();
        SmallWand.weaponType = "spell";
        SmallWand.weapBonus = 1;
        SmallWand.cost = 100;

        Weapon LargeWand = new Weapon();
        LargeWand.weaponType = "spell";
        LargeWand.weapBonus = 3;
        LargeWand.cost = 300;

        Weapon MagicRod = new Weapon();
        MagicRod.weaponType = "spell";
        MagicRod.weapBonus = 6;
        MagicRod.cost = 500;

        Weapon MagicStaff = new Weapon();
        MagicStaff.weaponType = "spell";
        MagicStaff.weapBonus = 6;
        MagicStaff.cost = 900;
    }
}
