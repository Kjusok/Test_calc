
using UnityEngine;
using UnityEngine.UI;


public class Calculator : MonoBehaviour
{
  
    public InputField FirstValInput;
    public InputField SecValInput;

    public float firstValue;
    public float secondValue;

    public string operation;


    public void Start()
    {
        
        FirstValInput.text = "0";
        
    }

    
    public void Plus()
    {
       float.TryParse(FirstValInput.text, out firstValue);
       operation = "+";
    }
    public void Minus()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "-";
    }
    public void Multi()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "*";
    }
    public void Div()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "/";
    }
    public void Pow()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "^";
    }
    public void Max()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = ">";
    }
    public void Min()
    {
        float.TryParse(FirstValInput.text, out firstValue);
        operation = "<";

    }

    public void GetAnswer()
        {

            float.TryParse(SecValInput.text, out secondValue);
            if (firstValue != 0 && secondValue != 0 && !string.IsNullOrEmpty(operation)) ;
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
                case ">":
                    if (firstValue >= secondValue)
                    {
                        FirstValInput.text = "" + firstValue + "";
                    }
                    else FirstValInput.text = "" + secondValue + "";
                    break;
                case "<":
                    if (firstValue <= secondValue)
                    {
                        FirstValInput.text = "" + firstValue + "";
                    }
                    else FirstValInput.text = "" + secondValue + "";
                    break;

            }


            }




        } 
      

   
    }
 



        
        

      