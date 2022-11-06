using System;

namespace Patterns.TemplateMethod;

public class ArmorSmith : GearCreate
{
    public override void ForgingMaterials()
    {
        Console.WriteLine("Making plates and leather preparing");
    }
}
