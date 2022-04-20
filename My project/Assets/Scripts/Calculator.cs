
using UnityEngine;
using UnityEngine.UI;


public class Calculator : MonoBehaviour
{
    public InputField FirstValueInput;
    public InputField SecondValueInput;

    public Text FactResults;

    public float firstValue;
    public float secondValue;

    // Start is called before the first frame update
    public void Start()
    {
        FactResults.text = "";
    }

    public void GetFirstvalue()
    {
       float.TryParse(FirstValueInput.text, out firstValue);
    }
    public void GetSecondValue()
    {
       float.TryParse(SecondValueInput.text, out secondValue);
    }
    public void ClickPlus()
    {
        float sum = firstValue + secondValue;

        FactResults.text = "" + sum + "";
        if (firstValue == 0)
        {
            FactResults.text = "Forgot to enter the first value?!";
        }
            }
    public void ClickMinus()
    {
        float DifferenceOfValues = firstValue - secondValue;
        FactResults.text = "" + DifferenceOfValues + "";
    }
    public void ClickMultiplication()
    {
        float MultiplicationOfValues = firstValue * secondValue;
        FactResults.text = "" + MultiplicationOfValues + "";
        if (firstValue == 0)
        {
            FactResults.text = "Forgot to enter the first value?!";
        }
                    }
    public void ClickDivision()
    {
        float DivisionOfValues = firstValue / secondValue;
                FactResults.text = "" + DivisionOfValues + "";
        if (secondValue == 0)
        {
            FactResults.text = "Dude, you can't divide by 0.";
        }

    }
        public void ClickPow()
    {
        float pow = Mathf.Pow(firstValue, secondValue);

        FactResults.text = "" + pow + "";
        if (firstValue == 0)
        {
            FactResults.text = "Forgot to enter the first value?!";
        }
            }
        public void ClickMax()
    {
        if (firstValue >= secondValue)
        {
            FactResults.text = "" + firstValue + "";
        }
        if (firstValue <= secondValue)
        {
            FactResults.text = "" + secondValue + "";
        }
            }
        public void ClickMin()
    {
        if (firstValue <= secondValue)
        {
            FactResults.text = "" + firstValue + "";
        }
        if (firstValue >= secondValue)
        {
            FactResults.text = "" + secondValue + "";
        }
            }
}





        
        

      