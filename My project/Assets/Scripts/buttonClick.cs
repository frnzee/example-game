using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class buttonClick : MonoBehaviour
{
    public InputField textField1;
    public InputField textField2;
    public Text result;
    float value1;
    float value2;
    public void Click()
    {
        if (string.IsNullOrEmpty(textField1.text))
        {
            result.text = "Empty field 1";
        }
        else if (string.IsNullOrEmpty(textField2.text))
        {
            result.text = "Empty field 2";
        }
        else
        {
            float.TryParse(textField1.text, out value1);
            float.TryParse(textField2.text, out value2);
            string currentbutton = EventSystem.current.currentSelectedGameObject.name;
            switch (currentbutton)
            {
                case "+":
                    {
                        result.text = (value1+value2).ToString("");
                        break;
                    }
                case "-":
                    {
                        result.text = (value1-value2).ToString("");
                        break;
                    }
                case "*":
                    {
                        result.text = (value1*value2).ToString("");
                        break;
                    }
                case "/":
                    {
                        if (value2 == 0)
                        {
                            result.text = "Can't divide by 0";
                        }
                        else
                        {
                           result.text = (value1/value2).ToString("");
                        }
                        break;
                    }
                case "min":
                    {
                        if (value1 < value2)
                        {
                            result.text = value1.ToString("");
                        }
                        else
                        {
                            result.text = value2.ToString("");
                        }
                        break;
                    }
                case "max":
                    {
                        if (value1 > value2)
                        {
                            result.text = value1.ToString("");
                        }
                        else
                        {
                            result.text = value2.ToString("");
                        }
                        break;
                    }
                case "exp":
                    {
                        result.text = Mathf.Pow(value1,value2).ToString("");
                        break;
                    }

            }
        }
    }
}