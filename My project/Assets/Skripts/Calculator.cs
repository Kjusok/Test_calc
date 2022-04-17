using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Calculator : MonoBehaviour
{
    public InputField FirstValueInput;
    public InputField SecondValueInput;

    public Text Fact_Results;

    public float firstValue;
    public float secondValue;





    // Start is called before the first frame update
    public void Start()
    {
        Fact_Results.text = "";


    }


    public void Get_first_value()
    {
        firstValue = float.Parse(FirstValueInput.text);
    }
    public void Get_second_value()
    {
        secondValue = float.Parse(SecondValueInput.text);

    }

    public void Click_plus()
    {
        float sum_of_values = firstValue + secondValue;

        Fact_Results.text = "" + sum_of_values + "";
        if (firstValue == 0)
        {
            Fact_Results.text = "Forgot to enter the first value?!";

        }

    }
    public void Click_minus()
    {
        float difference_of_values = firstValue - secondValue;

        Fact_Results.text = "" + difference_of_values + "";
    }
    public void Click_multiplication()
    {
        float multiplication_of_values = firstValue * secondValue;

        Fact_Results.text = "" + multiplication_of_values + "";
        if (firstValue == 0)
        {

            Fact_Results.text = "Forgot to enter the first value?!";

        }


    }
    public void Click_division()
    {
        float division_of_values = firstValue / secondValue;

        Fact_Results.text = "" + division_of_values + "";
        if (secondValue == 0)
        {

            Fact_Results.text = "Dude, you can't divide by 0.";
        }




    }

    public void Click_pow()
    {
        float pow_of_values = Mathf.Pow(firstValue, secondValue);

        Fact_Results.text = "" + pow_of_values + "";
        if (firstValue == 0)
        {

            Fact_Results.text = "Forgot to enter the first value?!";

        }

    }

    public void Click_max()
    {
        if (firstValue >= secondValue)
        {
            Fact_Results.text = "" + firstValue + "";
        }
        if (firstValue <= secondValue)
        {
            Fact_Results.text = "" + secondValue + "";
        }

    }

    public void Click_min()
    {
        if (firstValue <= secondValue)
        {
            Fact_Results.text = "" + firstValue + "";
        }
        if (firstValue >= secondValue)
        {
            Fact_Results.text = "" + secondValue + "";
        }

    }
}





        
        

      