using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{
    public int roll;
    public SpriteRenderer die;
    public TextMeshProUGUI rollNum;
    public Slider slider;
    //reference the ui for the roll number, and create a sprite renderer, slider, and int for the dice roll
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //when game starts, make sure the slider is set to whole numbers
        //set the minimum and maximum value for the dice roll
        slider.wholeNumbers = true;
        slider.minValue = 1;
        slider.maxValue = 6;
    }

    // Update is called once per frame
    void Update()
    {    

      

    }

    public void diceThrow()
    {
        //generate a random number between 1 and 6, display the number on the text.
        //match the value with the slider
        roll = Random.Range(1, 7);
        rollNum.text = roll.ToString();
        slider.value = roll;
        
    }
}
