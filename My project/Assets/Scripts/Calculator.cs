using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Calculator : MonoBehaviour
{
    public Text Result;
    public Text CurrentTask;
    private float _value1;
    private float _value2;
    private int operationSelector;
    public void AddNumeric(int number)
    {
        Result.text += number;
    }
    public void Clear()
    {
        Result.text = "";
        CurrentTask.text = "";
    }
    public void Addition()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + "+";
        Result.text="";
        operationSelector = 1;
    }
    public void Substraction()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + "-";
        Result.text = "";
        operationSelector = 2;
    }
    public void Multiplication()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + "*";
        Result.text = "";
        operationSelector = 3;
    }
    public void Division()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + "/";
        Result.text = "";
        operationSelector = 4;
    }
    public void FindMin()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " min?";
        Result.text = "";
        operationSelector = 5;
    }
    public void FindMax()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " max?";
        Result.text = "";
        operationSelector = 6;
    }
    public void Power()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " pow";
        Result.text = "";
        operationSelector = 7;
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
    }
    public void Cotangent()
    {
        _value1 = float.Parse(Result.text);
        CurrentTask.text = _value1.ToString() + " cotangent";
        Result.text = (1/Mathf.Tan(_value1)).ToString("");
    }
    public void Equals()
    {
        switch (operationSelector)
        {
            case 1:
                _value2 = _value1 + float.Parse(Result.text);
                Result.text = _value2.ToString("");
                CurrentTask.text = "";
                break;
            case 2:
                _value2 = _value1 - float.Parse(Result.text);
                Result.text = _value2.ToString("");
                CurrentTask.text = "";
                break;
            case 3:
                _value2 = _value1 * float.Parse(Result.text);
                Result.text = _value2.ToString("");
                CurrentTask.text = "";
                break;
            case 4:
                if (Result.text == "0")
                {
                    Result.text = "Can't divide by 0";
                }
                else
                {
                    _value2 = _value1 / float.Parse(Result.text);
                    Result.text = _value2.ToString("");
                    CurrentTask.text = "";
                }
                break;
            case 5:
                _value2 = float.Parse(Result.text);
                Result.text = "Min is "+ Mathf.Min(_value1, _value2).ToString("");
                CurrentTask.text = "";
                break;
            case 6:
                _value2 = float.Parse(Result.text);
                Result.text = "Max is " + Mathf.Max(_value1, _value2).ToString("");
                CurrentTask.text = "";
                break;
            case 7:
                _value2 = float.Parse(Result.text);
                Result.text = Mathf.Pow(_value1, _value2).ToString("");
                CurrentTask.text = "";
                break;
        }
    }
}
