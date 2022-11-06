using System;

namespace Patterns.TemplateMethod;

public class WeaponSmith : GearCreate
{
    public override void ForgingMaterials()
    {
        Console.WriteLine("Sharping iron blade and making handle");
    }
}
