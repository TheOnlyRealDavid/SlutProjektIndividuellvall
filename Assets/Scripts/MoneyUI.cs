using UnityEngine;
using TMPro; //importerar textmesh vilket behövs för att visa money

public class MoneyUI : MonoBehaviour
{
    public playerController player;  //importerar Gubbe scripten så jag kan använda playermoney
    public TextMeshProUGUI moneyText;

    void Update()
    {
        moneyText.text = "Money: " + player.playerMoney;
    }
}