using UnityEngine;

public class Roll : MonoBehaviour
{
    float rollSpeed = 180f;
   float maxRotation = 0f;
    bool isRotating = false;
    public GameObject dice;
    public SpriteRenderer sr;
    //create die's maximum rotation and bool that checks wheter the die is rotating

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get spriterenderer component attatched to this game object
        sr = GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        //only rotate the die if this is true
        if (isRotating == true)
        {
            //calculate how much to rotate this frame based on the speed and time

            //apply rotation to the z axis

            float rotateNow = rollSpeed * Time.deltaTime;
            dice.transform.Rotate(0, 0, rotateNow);
            maxRotation += rotateNow;
        }
        //if the die has done a full flip, complete the cycle, and then reset the max rotation to 0
        if (maxRotation >= 360f)
        {
            isRotating = false;
            maxRotation = 0f;
        }
    }

    public void diceFlip()
    {
        //functiion to be called when button is clicked, rotates the die
        isRotating = true;

    

    }
    
    public void ChangeColor()
    {
        //function to ba called when the slider is moved, this changes the die's colour
        sr.color = Random.ColorHSV();
        
    }
}
