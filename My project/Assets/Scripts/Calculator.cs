  
using UnityEngine;
using UnityEngine.UI;
public class Calculator : MonoBehaviour
{
    public InputField FirstValInput;
    public InputField SecValInput;
    public Text Rad;

    public float FirstValue;
    public float SecondValue;

    public string Operation;
    public bool InputSecondValue;

    public void Start()
    {
        FirstValInput.text = "0";
        InputSecondValue = false;
    }
    // operations
    public void Zeroing()
    {
        FirstValInput.text = "0";
        Operation = null;
    }
    public void Operations()
    {
        float.TryParse(FirstValInput.text, out FirstValue);
        InputSecondValue = true;
    }
    public void Plus()
    {
        Operation = "+";
    }
    public void Minus()
    {
        Operation = "-";
    }
    public void Multi()
    {
        Operation = "*";
    }
    public void Div()
    {
        Operation = "/";
    }
    public void Pow()
    {
        Operation = "^";
    }
    public void Log10()
    {
        float.TryParse(FirstValInput.text, out FirstValue);
        float Log10 = Mathf.Log10(FirstValue);
        FirstValInput.text = "" + Log10 + "";
    }
    public void Log2()
    {
        float.TryParse(FirstValInput.text, out FirstValue);
        float Log2 = Mathf.Log(FirstValue, 2);
        FirstValInput.text = "" + Log2 + "";
    }
    public void Sin()
    {
        float.TryParse(FirstValInput.text, out FirstValue);
        switch (Rad.text)
        {
            case "Rad":
                float Sin = Mathf.Sin(FirstValue);
                FirstValInput.text = "" + Sin + "";
                break;
            case "Deg":
                FirstValue = Mathf.PI * FirstValue / 180;
                float SinDeg = Mathf.Sin(FirstValue);
                FirstValInput.text = "" + SinDeg + "";
                break;
        }
    }
    public void Cot()
    {
        float.TryParse(FirstValInput.text, out FirstValue);
        switch (Rad.text)
        {
            case "Rad":
                float Cot = (Mathf.Cos(FirstValue) / Mathf.Sin(FirstValue));
                FirstValInput.text = "" + Cot + "";
                break;
            case "Deg":
                FirstValue = Mathf.PI * FirstValue / 180;
                float CotDeg = (Mathf.Cos(FirstValue) / Mathf.Sin(FirstValue));
                FirstValInput.text = "" + CotDeg + "";
                break;
        }
    }
    public void Pi()
    {
        double PiVal = Mathf.PI;
        FirstValInput.text = "" + PiVal + "";
    }
    public void Factorize()
    {
        float.TryParse(FirstValInput.text, out FirstValue);
        FirstValue = Mathf.Round(FirstValue);
        int divider = 2;
        FirstValInput.text = "" + FirstValue + "" + "=1";
        while (FirstValue > 1)
        {
            while (FirstValue % divider == 0)
            {
                FirstValInput.text += "*" + "" + divider + "";
                FirstValue = FirstValue / divider;
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
    public void InputNumbers(int number)
    {
        if (FirstValInput.text == "0")
        {
            FirstValInput.text = number.ToString();
        }
        else
        {
            FirstValInput.text += number.ToString();
        }
        if (InputSecondValue)
        {
            InputSecondValue = false;
            FirstValInput.text = number.ToString();
        }
    }
    public void One()
    {
        InputNumbers(1);
    }
    public void Two()
    {
        InputNumbers(2);
    }
    public void Three()
    {
        InputNumbers(3);
    }
    public void Four()
    {
        InputNumbers(4);
    }
    public void Five()
    {
        InputNumbers(5);
    }
    public void Six()
    {
        InputNumbers(6);
    }
    public void Seven()
    {
        InputNumbers(7);
    }
    public void Eigth()
    {
        InputNumbers(8);
    }
    public void Nine()
    {
        InputNumbers(9);
    }
    public void Zero()
    {
        InputNumbers(0);
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
    public void PlusOrMinus()
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
        float.TryParse(SecValInput.text, out SecondValue);
        {
            switch (Operation)
            {
                case "+":
                    float sum = FirstValue + SecondValue;
                    FirstValInput.text = "" + sum + "";
                    break;
                case "-":
                    float DifferenceOfValues = FirstValue - SecondValue;
                    FirstValInput.text = "" + DifferenceOfValues + "";
                    break;
                case "*":
                    float MultiplicationOfValues = FirstValue * SecondValue;
                    FirstValInput.text = "" + MultiplicationOfValues + "";
                    break;
                case "/":
                    float DivisionOfValues = FirstValue / SecondValue;
                    FirstValInput.text = "" + DivisionOfValues + "";
                    if (SecondValue == 0)
                    {
                        FirstValInput.text = "На ноль делить нельзя!";
                    }
                    break;
                case "^":
                    float pow = Mathf.Pow(FirstValue, SecondValue);
                    FirstValInput.text = "" + pow + "";
                    break;
            }
        }
    }
}
 



        
        

      