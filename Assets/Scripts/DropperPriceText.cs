using UnityEngine;
using TMPro; //Gör så jag kan använda TextMeshPro

public class DropperPriceText : MonoBehaviour
{
    [SerializeField] 
    Vector3 offset = new Vector3(0, 1f, 0); //Vectorn bestämmer vart min DropperPrice text ska vara

    TextMeshPro text; //skapar en variabel där jag tänker spara TextMeshPro i

    void Start()
    {
        text = GetComponent<TextMeshPro>(); // Här kopplas min text varabel till texten
        transform.localPosition = offset; // Gör så texten är över DropperSpawner
    }

    void Update()
    {
        text.text = "Cost: " + DropperSpawner.GetPrice(); // Hämtar priset från DropperSpawner Scriptet
    }
}