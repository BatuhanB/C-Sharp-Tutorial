namespace DesignPatterns.Creational.Builder.Concrets;
public class Food
{
    public decimal Pepper { get; set; }
    public decimal Water { get; set; }
    public decimal Salt { get; set; }

    public override string ToString()
    {
        return $"Pepper: {Pepper} Gr. - Salt: {Salt} Gr. - Water: {Water} ml.";
    }
}