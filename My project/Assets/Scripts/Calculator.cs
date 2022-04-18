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
    float value1;
    float value2;
    float resultvalue;
    public void Plus()
    {
        if (string.IsNullOrEmpty(textField1.text))
        {
            Result.text = "Empty field 1";
        }
        else if (string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field 2";
        }
        else
        {
            float.TryParse(textField1.text, out value1);
            float.TryParse(textField2.text, out value2);
            resultvalue = value1 + value2;
            Result.text = resultvalue.ToString("");
        }
    }
    public void Minus()
    {
        if (string.IsNullOrEmpty(textField1.text))
        {
            Result.text = "Empty field 1";
        }
        else if (string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field 2";
        }
        else
        {
            float.TryParse(textField1.text, out value1);
            float.TryParse(textField2.text, out value2);
            resultvalue = value1 - value2;
            Result.text = resultvalue.ToString("");
        }
    }
    public void Multiply()
    {
        if (string.IsNullOrEmpty(textField1.text))
        {
            Result.text = "Empty field 1";
        }
        else if (string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field 2";
        }
        else
        {
            float.TryParse(textField1.text, out value1);
            float.TryParse(textField2.text, out value2);
            resultvalue = value1 * value2;
            Result.text = resultvalue.ToString("");
        }
    }
    public void Divide()
    {
        if (string.IsNullOrEmpty(textField1.text))
        {
            Result.text = "Empty field 1";
        }
        else if (string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field 2";
        }
        else if (value2==0)
        {
            Result.text = "Can't divide by 0";
        }
        else
        {
            float.TryParse(textField1.text, out value1);
            float.TryParse(textField2.text, out value2);
            resultvalue = value1 / value2;
            Result.text = resultvalue.ToString("");
        }        
    }
    public void FindMin()
    {
        float.TryParse(textField1.text, out value1);
        float.TryParse(textField2.text, out value2);
        if (string.IsNullOrEmpty(textField1.text))
        {
            Result.text = "Empty field 1";
        }
        else if (string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field 2";
        }
        else if (value1 < value2)
        {
            Result.text = value1.ToString("");
        }
        else
        {
            float.TryParse(textField2.text, out value2);
            Result.text = value2.ToString("");
        }
    }
    public void FindMax()
        {
        float.TryParse(textField1.text, out value1);
        float.TryParse(textField2.text, out value2);
        if (string.IsNullOrEmpty(textField1.text))
        {
            Result.text = "Empty field 1";
        }
        else if (string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field 2";
        }
        else if (value1 > value2)
        {
            Result.text = value1.ToString("");
        }
        else
        {
            float.TryParse(textField2.text, out value2);
            Result.text = value2.ToString("");
        }
    }

    public void Exponenciate()
    {
        if (string.IsNullOrEmpty(textField1.text))
        {
            Result.text = "Empty field 1";
        }
        else if (string.IsNullOrEmpty(textField2.text))
        {
            Result.text = "Empty field 2";
        }
        else
        {
            float.TryParse(textField1.text, out value1);
            float.TryParse(textField2.text, out value2);
            resultvalue = Mathf.Pow(value1,value2);
            Result.text = resultvalue.ToString("");
        }
    }    
}
