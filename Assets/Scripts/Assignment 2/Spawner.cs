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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        timerOn = true;

        if (timerOn == true)
        {
            timer += Time.deltaTime;
        }

        

        if (timer > 5)
        {
            timer = 0;
            if (tanks.Count < 5)
            {
                float randomX = Random.Range(0, Screen.width);
                float randomY = Random.Range(0, Screen.height);
                Vector3 screenPos = new Vector3(randomX, randomY, 10f);
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

                timer = 0;
                spawnedTank = Instantiate(tank, worldPos, Quaternion.identity);
                tankMove = spawnedTank.GetComponent<Move>();
                tanks.Add(spawnedTank);
            }
        }

        if (slider.value == 3 && lastValue !=3 &&tanks.Count >0)
        {
            Destroy(tanks[0]);
            tanks.RemoveAt(0);
            destroyed++;
            death.text = destroyed.ToString();

        }

        lastValue = slider.value;
        
    }
}
