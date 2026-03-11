using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DropperSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject DropperPrefab;
        void Start()
    {
        
    }

    void Update()
    {
        
    }

       void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (collision.gameObject.tag == "Player")
            {
            playerController player = collision.GetComponent<playerController>();

                if(player.playerMoney > 100)
                {
                    Instantiate(DropperPrefab, transform.position, Quaternion.identity);
                    player.playerMoney -= 100;
                    Destroy(this.gameObject);
                }
                
            }
        
            
        }
    }
}
