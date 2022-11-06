namespace Patterns.TemplateMethod;

public abstract class GearCreate
{
    public virtual void ForgeGear()
    {
        PrepereMaterials();
        ForgingMaterials();
        CombineMaterials();
    }

    public void PrepereMaterials() { }
    public abstract void ForgingMaterials();
    public void CombineMaterials() { }
}