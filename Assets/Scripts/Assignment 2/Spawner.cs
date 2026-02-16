using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject tank;
    public float timer;
    public Move tankMove;
    public GameObject spawnedTank;
    public List<GameObject> tanks;
    bool timerOn;
    public Slider slider;
    private float lastValue;
    public TextMeshProUGUI death;
    float destroyed;
    //reference the tank prefab, create a timer for the tank spawner, reference the move script for tank movement, reference to store the most recently spawned tanks
    //a list to keep track, a bool to control wheter the timer is on, a slider to control tank deaths, and a counter  to track the deaths
    void Start()
    {
        //timer counts when game starts
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {

       
        //add up the time since the last frame
        if (timerOn == true)
        {
            timer += Time.deltaTime;
        }

        
        //if the timer is greater than 5 seconds, spawn a tank at a random position, add it to the list, and reset the timer to 0
        if (timer > 5)
        {
            timer = 0;

            // only spawn a new tank if there are less than 5 on screen
            if (tanks.Count < 5)
            {
                float randomX = Random.Range(0, Screen.width);
                float randomY = Random.Range(0, Screen.height);
                Vector3 screenPos = new Vector3(randomX, randomY, 10f);
                // Convert the screen position to world position for spawning
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

                timer = 0;
                // Spawn the tank at the calculated position with no rotation
                spawnedTank = Instantiate(tank, worldPos, Quaternion.identity);
                // Get the Move component from the newly spawned tank
                tankMove = spawnedTank.GetComponent<Move>();
                // Add the spawned tank to our list
                tanks.Add(spawnedTank);
            }
        }
        //check if the die rolled a 3. and if it was not, the tank still exists.
        if (slider.value == 3 && lastValue !=3 &&tanks.Count >0)
        {
            //destroy the first tank from our list, remove it, and add it to the destroyed counter on the ui
            Destroy(tanks[0]);
            tanks.RemoveAt(0);
            destroyed++;
            death.text = destroyed.ToString();

        }
        //store the last value rolled from the dice within the slider to compare again
        lastValue = slider.value;
        
    }
}
