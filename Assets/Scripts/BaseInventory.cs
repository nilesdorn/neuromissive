using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInventory : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>(); // List to store items
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    // Add an item to the inventory
    public void AddItem(GameObject item)
    {
        items.Add(item);
        // Implement logic to update the UI or perform other actions
    }

    // Remove an item from the inventory
    public void RemoveItem(GameObject item)
    {
        items.Remove(item);
        // Implement logic to update the UI or perform other actions
    }
}
