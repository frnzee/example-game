using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Calculator : MonoBehaviour
{
    public Text Result;
    public InputField textField1;
    public InputField textField2;
    private float _value1;
    private float _value2;
    public void Addition()
    {
        if (string.IsNullOrEmpty(textField1.text) || string.IsNullOrEmpty(textField2.text))
        
        {
            Result.text = "Empty field";
        }
        else
        {
            _value1 = float.Parse(textField1.text);
            _value2 = float.Parse(textField2.text);
            Result.text = (_value1 + _value2).ToString("");
        }
    }
    public void Substraction()
    {
        if (string.IsNullOrEmpty(textField1.text) || string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field";
        }
        else
        {
            _value1 = float.Parse(textField1.text);
            _value2 = float.Parse(textField2.text);
            Result.text = (_value1 - _value2).ToString("");
        }
    }
    public void Multiplication()
    {
        if (string.IsNullOrEmpty(textField1.text) || string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field";
        }
        else
        {
            _value1 = float.Parse(textField1.text);
            _value2 = float.Parse(textField2.text);
            Result.text = (_value1 * _value2).ToString("");
        }
    }
    public void Division()
    {
        if (string.IsNullOrEmpty(textField1.text) || string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field";
        }
        else if (_value2 == 0)
        {
            Result.text = "Can't divide by 0";
        }
        else
        {
            _value1 = float.Parse(textField1.text);
            _value2 = float.Parse(textField2.text);
            Result.text = (_value1 / _value2).ToString("");
        }
    }
    public void FindMin()
    {
        if (string.IsNullOrEmpty(textField1.text) || string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field";
        }
        else
        {
            _value1 = float.Parse(textField1.text);
            _value2 = float.Parse(textField2.text);
            Result.text = Mathf.Min(_value1, _value2).ToString("");
        }
    }
    public void FindMax()
    {
        if (string.IsNullOrEmpty(textField1.text) || string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field";
        }
        else
        {
            _value1 = float.Parse(textField1.text);
            _value2 = float.Parse(textField2.text);
            Result.text = Mathf.Max(_value1, _value2).ToString("");
        }
    }
    public void Power()
    {
        if (string.IsNullOrEmpty(textField1.text) || string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field";
        }
        else
        {
            _value1 = float.Parse(textField1.text);
            _value2 = float.Parse(textField2.text);
            Result.text = Mathf.Pow(_value1, _value2).ToString("");
        }
    }
}
