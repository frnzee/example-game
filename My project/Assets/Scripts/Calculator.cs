using UnityEngine;
using UnityEngine.UI;
public class Calculator : MonoBehaviour
{
    public Text Result;
    public Text CurrentTask;
    private float _value1;
    private float _value2;
    private float _result;
    private enum OperationSelector
    {
        Addition,
        Substaction,
        Multiplication,
        Division,
        FindMin,
        FindMax,
        Power
    }
    private OperationSelector _myOperation;
    private bool _needClear = true;
    private bool _percent = false;
    public void AddNumeric(int number)
    {
        if (_needClear)
        {
            Result.text = "";
            Result.text += number;
            _needClear = false;
        }
        else
        {
            Result.text += number;
        }
    }
    public void Comma()
    {
        Result.text += ".";
    }
    public void Clear()
    {
        Result.text = "0";
        CurrentTask.text = "";
        _needClear = true;
    }
    public void PlusMinus()
    {
        _value1 = -(float.Parse(Result.text));
        Result.text = _value1.ToString();
    }
    public void Addition()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + "+";
        Result.text = "";
        _myOperation = OperationSelector.Addition;
    }
    public void Substraction()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + "-";
        Result.text = "";
        _myOperation = OperationSelector.Substaction;
    }
    public void Multiplication()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + "*";
        Result.text = "";
        _myOperation = OperationSelector.Multiplication;
    }
    public void Division()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + "/";
        Result.text = "";
        _myOperation = OperationSelector.Division;
    }
    public void FindMin()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = "Which one is lesser " + _value1.ToString() + " or";
        Result.text = "";
        _myOperation = OperationSelector.FindMin;
    }
    public void FindMax()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = "Which one is greater " + _value1.ToString() + " or";
        Result.text = "";
        _myOperation = OperationSelector.FindMax;
    }
    public void Power()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " pow";
        Result.text = "";
        _myOperation = OperationSelector.Power;
    }
    public void Logarithm10()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " log10";
        Result.text = Mathf.Log10(_value1).ToString("");
    }
    public void Logarithm2()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " log2";
        Result.text = Mathf.Log(_value1).ToString("");
    }
    public void PiNumber()
    {
        Result.text = Mathf.PI.ToString("");
    }
    public void Sinus()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " sinus";
        Result.text = Mathf.Sin(_value1).ToString("");
        _value1 = Mathf.Sin(_value1);
        _needClear = true;
    }
    public void Cotangent()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " cotangent";
        Result.text = (1 / Mathf.Tan(_value1)).ToString("");
    }
    public void PrimesFinder()
    {
        _value1 = float.Parse(Result.text);
        string s = string.Empty;
        int i, n;
        n = ((int)_value1);
        if (n < 2)
        {
            Result.text = "wrong value";
            _needClear = true;
        }
        else
        {
            while ((n % 2) == 0)
            {
                n /= 2;
                s += "2*";
            }
            i = 3;
            while (i <= Mathf.Sqrt(n))
            {
                if ((n % i) == 0)
                {
                    if (n / i * i - n == 0)
                    {
                        s += i.ToString() + "*";
                        n /= i;
                    }
                    else
                    {
                        i += 2;
                    }
                }
                else
                {
                    i += 2;
                }
            }
            s += n.ToString();
            Result.text = s;
        }
    }
    public void Percent()
    {
        CurrentTask.text += float.Parse(Result.text) + "%";
        _value2 = float.Parse(Result.text);
        Result.text = "";
        _percent = true;
    }
    public void Equals()
    {
        if (_percent)
        {
            switch (_myOperation)
            {
                case OperationSelector.Addition:
                    _result = _value1 + (_value1 * (_value2) / 100);
                    Result.text = _result.ToString("");
                    CurrentTask.text = "";
                    break;
                case OperationSelector.Substaction:
                    _result = _value1 - (_value1 * (_value2) / 100);
                    Result.text = _result.ToString("");
                    CurrentTask.text = "";
                    break;
                case OperationSelector.Multiplication:
                    _result = _value1 * (_value1 * (_value2) / 100);
                    Result.text = _result.ToString("");
                    CurrentTask.text = "";
                    break;
                case OperationSelector.Division:
                    _result = _value1 / (_value1 * (_value2) / 100);
                    Result.text = _result.ToString("");
                    CurrentTask.text = "";
                    break;
            }
            _percent = false;
        }
        else
        {
            switch (_myOperation)
            {
                case OperationSelector.Addition:
                    _result = _value1 + float.Parse(Result.text);
                    Result.text = _result.ToString("");
                    CurrentTask.text = "";
                    break;
                case OperationSelector.Substaction:
                    _result = _value1 - float.Parse(Result.text);
                    Result.text = _result.ToString("");
                    CurrentTask.text = "";
                    break;
                case OperationSelector.Multiplication:
                    _result = _value1 * float.Parse(Result.text);
                    Result.text = _result.ToString("");
                    CurrentTask.text = "";
                    break;
                case OperationSelector.Division:
                    if (Result.text == "0")
                    {
                        Result.text = "Can't divide by 0";
                        _needClear = true;
                    }
                    else
                    {
                        _result = _value1 / float.Parse(Result.text);
                        Result.text = _result.ToString("");
                        CurrentTask.text = "";
                    }
                    break;
                case OperationSelector.FindMin:
                    _result = float.Parse(Result.text);
                    Result.text = Mathf.Min(_value1, _result).ToString("") + " is lesser";
                    CurrentTask.text = "";
                    _needClear = true;
                    break;
                case OperationSelector.FindMax:
                    _result = float.Parse(Result.text);
                    Result.text = Mathf.Max(_value1, _result).ToString("") + " is greater";
                    CurrentTask.text = "";
                    _needClear = true;
                    break;
                case OperationSelector.Power:
                    _result = float.Parse(Result.text);
                    Result.text = Mathf.Pow(_value1, _result).ToString("");
                    CurrentTask.text = Result.text;
                    _value1 = Mathf.Pow(_value1, _result);
                    _needClear = true;
                    break;
            }
        }
    }
}
