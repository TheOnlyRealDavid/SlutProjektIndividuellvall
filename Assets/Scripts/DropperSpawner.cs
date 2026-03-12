using UnityEngine;

public class DropperSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject DropperPrefab;
    
    static int dropperPrice = 100; // Static för att alla cloner ska dela på samma variabel

       void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerController player = collision.GetComponent<playerController>();

                if(player.playerMoney >= dropperPrice)
                {
                    Instantiate(DropperPrefab, transform.position, Quaternion.identity); //spawnar droppern på samma plats som SpawnerSpriten

                    player.playerMoney -= dropperPrice;

                    dropperPrice *= 2; //Nästa dropper kommer att ha ökat priset med 100%

                    Destroy(this.gameObject); // förstör spawnerSpriten efter att ha spawnat droppern
                    
                }
                
        }
    }
}
