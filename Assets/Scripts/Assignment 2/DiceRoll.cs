using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    public int roll;
    public SpriteRenderer die;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    

     

    }

    public void diceThrow()
    {

        roll = Random.Range(1, 7);
        
    }
}
