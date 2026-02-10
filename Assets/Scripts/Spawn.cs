using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Spawn : MonoBehaviour
{
    public GameObject knifePrefab;
    public List<GameObject> knives;
    public bool pop = false;
    public SpriteRenderer sharp;
    public GameObject pirate;
    public int roll;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        knives = new List<GameObject>();
        for (int i = 0; i < 5; i++)
        {
            GameObject stab = Instantiate(knifePrefab, new Vector3(i*1,-1,2), Quaternion.identity);
            knives.Add(stab); 
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
       
        if (sharp.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            roll = Random.Range(0, 5);
           
        }
       
        if (roll== 3)
        {
            Destroy(pirate);
            pop = true;
        }
        else
        {
            Destroy(knives[0]);
        }
        
        

    }
}
