using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    //create speed float
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {    //add speed to x value to make the object move
        Vector3 newPosition = transform.position;
        newPosition.x += speed;
        transform.position = newPosition; ;
        //check if the object has made it to the end of the scree, if so, reverse the speed
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
    }
}