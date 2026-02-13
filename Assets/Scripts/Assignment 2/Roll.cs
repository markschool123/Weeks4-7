using UnityEngine;

public class Roll : MonoBehaviour
{
    float rollSpeed = 180f;
   float maxRotation = 0f;
    bool isRotating = false;
    public GameObject dice;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating == true)
        {
            float rotateNow = rollSpeed * Time.deltaTime;
            dice.transform.Rotate(0, 0, rotateNow);
            maxRotation += rotateNow;
        }
        if (maxRotation >= 360f)
        {
            isRotating = false;
            maxRotation = 0f;
        }
    }

    public void diceFlip()
    {
        isRotating = true;

    

    }
}
