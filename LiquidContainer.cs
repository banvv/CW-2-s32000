namespace CW_2_s32000;

public class LiquidContainer : Container
{
    public ContentType ContentType { get; set; }

    public override void AddContent(float mass)
    {
        switch (ContentType)
        {
            case ContentType.Normal:
                if (mass > CapacityMass * .9)
                    
                break;
            case ContentType.Hazardous:
                if (mass > CapacityMass / 2)
                    throw new OverfillException();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        ContentMass = mass;
    }
}

public enum ContentType
{
    Normal,
    Hazardous
}