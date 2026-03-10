using UnityEngine;

public class moneyGenerator : MonoBehaviour
{

    [SerializeField]
   public int money = 0;
   public int bonus = 1;

float TimeSinceLastMoney = 0;
[SerializeField]
   float timeBetweenMoney = 1f;

    void Start()
    {
        money = 0;
    }

    void Update()
    {
        TimeSinceLastMoney += Time.deltaTime;
        if(TimeSinceLastMoney >= timeBetweenMoney)
        {
            money ++;
            TimeSinceLastMoney = 0;
        }
    }
}
