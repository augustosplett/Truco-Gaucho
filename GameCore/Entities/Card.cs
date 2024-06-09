namespace GameCore.Entities
{
    public class Card
    {
        public Suit Suit { get; set; }
        public string FaceValue { get; set; }
        public int RealValue { get; set; }

        public override string? ToString()
        {
            return $"Suit: {Suit.ToString()} | Facevalue: {FaceValue} | RealValue {RealValue}";
        }
    }
}
