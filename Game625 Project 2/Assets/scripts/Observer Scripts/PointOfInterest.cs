using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterest : Subject
{
    [SerializeField]
    private string poiName;

    public GameManager gm;

    public Item Item;

    void Pickup()
    {
        InventoryManager.Instance.Add(Item);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Healthy")
        {
            Notify(poiName, NotificationType.AchievementUnlocked);
            Pickup();
            /*
            gm.healthy++;
            gm.hunger = gm.hunger + 25;
            Debug.Log("Healthy food: " + gm.healthy);
            Debug.Log("Fullness: " + gm.hunger);
            */
        }
        if (gameObject.tag == "Junk")
        {
            Notify(poiName, NotificationType.AchievementUnlocked);
            Pickup();
            /*
            gm.junk++;
            gm.hunger = gm.hunger + 25;
            Debug.Log("Healthy food: " + gm.healthy);
            Debug.Log("Fullness: " + gm.hunger);
            */
        }
    }
}
