﻿//using Patterns.Strategy;
//using Patterns.FactoryMethod;
using Patterns.TemplateMethod;
using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
            //Hero heroAxe = new Hero(new Axe(damage: 90));
            //Hero heroBlade = new Hero(new Blade(damage: 95));

            //int monsterDef = 75;

            //Console.WriteLine($"Axe: {heroAxe.Attack(monsterDef)}");
            //Console.WriteLine($"Axe: {heroBlade.Attack(monsterDef)}");
            #endregion

            #region Factory Method
            //Necromancer necromancer = new Necromancer( new RaiseSceleton(), new RaiseZombie());
            //necromancer.Skills[0].Raise();
            #endregion

            #region TamplateMethod

            ArmorSmith aSmith = new ArmorSmith();
            WeaponSmith wSmith = new WeaponSmith();

            aSmith.ForgeGear();
            Console.WriteLine("Armor Ready!!!\n");

            wSmith.ForgeGear();
            Console.WriteLine("Weapon Ready!!!\n");

            #endregion

            Console.ReadLine();
        }
    }
}
