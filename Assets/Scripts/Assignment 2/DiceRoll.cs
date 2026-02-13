using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{
    public int roll;
    public SpriteRenderer die;
    public TextMeshProUGUI rollNum;
    public Slider slider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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

        roll = Random.Range(1, 7);
        rollNum.text = roll.ToString();
        slider.value = roll;
        
    }
}
