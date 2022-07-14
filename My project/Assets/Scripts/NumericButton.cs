using UnityEngine;

public class NumericButton : MonoBehaviour
{
    public enum NumericType
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9
    }
    public NumericType Numeric;
    public Calculator Calculator;
    public void Click()
    {
        Calculator.AddNumeric((int)Numeric);
    }
}
