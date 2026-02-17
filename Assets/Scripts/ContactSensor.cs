using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterHazard;
    public UnityEvent OnExitHazard;
    public SpriteRenderer bomb;
    public UnityEvent OnEnterBomb;
    public UnityEvent OnEnterHeal;
    public SpriteRenderer healer;
    public UnityEvent<float> OnRandomNumber;
    public SpriteRenderer square;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (healer.bounds.Contains(transform.position) == true)
        {
            OnEnterHeal.Invoke();
        }

        if (bomb.bounds.Contains(transform.position) ==true)
        { 
            OnEnterBomb.Invoke();
        }

        if (hazard.bounds.Contains(transform.position) ==true)
        {
            if (isInHazard ==true)
            {

            }
            else
            {
                isInHazard = true;
                Debug.Log("Entered the Hazard!");
                OnEnterHazard.Invoke();
                OnRandomNumber.Invoke(Random.Range(0, 10));
            }
        }
        else
        {
            if (isInHazard ==true)
            {
                isInHazard=false;
                Debug.Log("Exited the Hazard");
                OnExitHazard.Invoke();
            }
            else
            {

            }

        }
    }

    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
