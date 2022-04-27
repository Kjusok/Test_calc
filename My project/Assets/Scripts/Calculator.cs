  
using UnityEngine;
using UnityEngine.UI;


public class Calculator : MonoBehaviour
{
    public InputField FirstValInput;
    public InputField SecValInput;
    public Text Rad;

    public float firstValue;
    public float secondValue;

    public string operation;
    public bool InputSecondValue;
    
    public void Start()
    {
        FirstValInput.text = "0";
        InputSecondValue = false;
    }

    // operations
    public void CE ()
    {
        FirstValInput.text = "0";
        operation = null;
    }
    public void Plus()
    {
       float.TryParse(FirstValInput.text, out firstValue);
       operation = "+";
        InputSecondValue = true;
    }
    public void Minus()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "-";
        InputSecondValue = true;
    }
    public void Multi()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "*";
        InputSecondValue = true;
    }
    public void Div()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "/";
        InputSecondValue = true;
    }
    public void Pow()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "^";
        InputSecondValue = true;
    }
    public void Log10()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        float Log10 = Mathf.Log10(firstValue);
        FirstValInput.text = "" + Log10 + "";
    }
    public void Log2()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        float Log2 = Mathf.Log(firstValue,2);
        FirstValInput.text = "" + Log2 + "";
    }
    public void Sin()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        switch (Rad.text)
        {
            case "Rad": 
         float Sin = Mathf.Sin(firstValue);
        FirstValInput.text = "" + Sin + "";
                break;
            case "Deg":
                
                firstValue= Mathf.PI * firstValue/180;
                float SinDeg = Mathf.Sin(firstValue);
                FirstValInput.text = "" + SinDeg + "";
                break;
        }
    }
    public void Cot()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        switch(Rad.text)
        {
            case "Rad":
                float Cot = (Mathf.Cos(firstValue) / Mathf.Sin(firstValue));
                FirstValInput.text = "" + Cot + "";
                break;
            case "Deg":
                firstValue = Mathf.PI * firstValue / 180;
                float CotDeg = (Mathf.Cos(firstValue) / Mathf.Sin(firstValue));
                FirstValInput.text = "" + CotDeg + "";
                break;

        }
    }
    public void Pi()
    {
        double PiVal = Mathf.PI;
        FirstValInput.text = ""+PiVal+"";
    }
    public void Factorize()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        firstValue = Mathf.Round(firstValue);
        int divider = 2;
        FirstValInput.text = "" + firstValue + "" + "=1";
        while (firstValue > 1)
        {
            while (firstValue % divider == 0)
            {
                FirstValInput.text += "*"+"" + divider + "";
                firstValue = firstValue / divider;
            }
            divider++;
        }
        
    }
    public void RadDeg()
    {
        if (Rad.text == "Rad") 
        {
            Rad.text = "Deg";
        }
         else Rad.text = "Rad";
    }
    // numbers
    public void one()
    {
            if (FirstValInput.text == "0")
            {
                FirstValInput.text = "1";
            }
            else
            {
                FirstValInput.text += "1";
            }
            if (InputSecondValue) 
            {
            InputSecondValue = false;
            FirstValInput.text = "1";
            }
    }
    public void two()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "2";
        }
        else
        {
            FirstValInput.text += "2";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "2";
        }
    }
    public void three()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "3";
        }
        else
        {
            FirstValInput.text += "3";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "3";
        }
    }
    public void Four()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "4";
        }
        else
        {
            FirstValInput.text += "4";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "4";
        }
    }
    public void Five()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "5";
        }
        else
        {
            FirstValInput.text += "5";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "5";
        }
    }
    public void Six()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "6";
        }
        else
        {
            FirstValInput.text += "6";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "6";
        }
    }
    public void Seven()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "7";
        }
        else
        {
            FirstValInput.text += "7";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "7";
        }
    }
    public void Eigth()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "8";
        }
        else
        {
            FirstValInput.text += "8";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "8";
        }
    }
    public void Nine()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "9";
        }
        else
        {
            FirstValInput.text += "9";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "9";
        }
    }
    public void Zero()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "0";
        }
        else
        {
            FirstValInput.text += "0";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "0";
        }
    }
    public void Point()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "0,";
        }
        else
        {
            FirstValInput.text += ",";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = ",";
        }
    }
    public void PlusOrMinus ()
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = "-";
        }
        else
        {
            FirstValInput.text += "";
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = "-";
        }
    }
    //results
    public void GetAnswer()
        {
            float.TryParse(SecValInput.text, out secondValue);
            {
                switch (operation)
                {
                    case "+":
                        float sum = firstValue + secondValue;
                        FirstValInput.text = "" + sum + "";
                        break;
                case "-":
                        float DifferenceOfValues = firstValue - secondValue;
                        FirstValInput.text = "" + DifferenceOfValues + "";
                        break;
                    case "*":
                        float MultiplicationOfValues = firstValue * secondValue;
                        FirstValInput.text = "" + MultiplicationOfValues + "";
                         break;
                    case "/":
                         float DivisionOfValues = firstValue / secondValue;
                         FirstValInput.text = "" + DivisionOfValues + "";
                    if (secondValue == 0)
                    {
                        FirstValInput.text = "На ноль делить нельзя!";
                    }
                    break;
                    case "^":
                        float pow = Mathf.Pow(firstValue, secondValue);
                        FirstValInput.text = "" + pow + "";
                    break;
            }
            }
        } 
   
    }
 



        
        

      