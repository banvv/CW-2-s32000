namespace CW_2_s32000;

public abstract class Container
{
    public float ContentMass { get; set; } // kilogram
    public float Height { get; set; } // centimeter
    public float SelfMass { get; set; } //kg
    public float Depth { get; set; } // cm
    public string SerialNr { get; set; }
    public float CapacityMass { get; set; } // kg


    public void Empty()
    {
        ContentMass = 0;
    }

    public abstract void AddContent(float mass)

    private bool _check_new_content_mass(float mass)
    {
        return mass > ContentMass;
    }
}

public class OverfillException : Exception
{
}