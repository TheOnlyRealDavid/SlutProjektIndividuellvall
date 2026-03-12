using UnityEngine;

public class dropperController : MonoBehaviour
{   
    void Start()
    {
        moneyGenerator generator = FindObjectOfType<moneyGenerator>(); //Letar efter moneGenerator obejktet
        generator.bonus++;
    }
}
