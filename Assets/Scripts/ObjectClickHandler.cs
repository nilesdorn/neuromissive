using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class ObjectClickHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private BaseInventory playerInventory; // Player inventory
    [SerializeField]
    private BaseInventory inventory; // GameObject inventory
    [SerializeField]
    private Material baseMaterial;
    [SerializeField]
    private Material highlightMaterial;
    public bool interactable = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;
            
            // Check if the hit object is the one you want to highlight
            if (hitObject == gameObject)
            {
                MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
                // Apply highlighting effect
                // For example, change the material or shader properties
                // Assuming you have a reference to the original and highlight materials
                

                // Apply the highlight material
                renderer.material = highlightMaterial;
            }

            else
            
            {
                MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
                renderer.material = baseMaterial;
            }
        }



        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(1))
        {
            

            // Perform a raycast to detect the GameObject
            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                // Check if the raycast hit our GameObject
                if (hit.collider.gameObject == gameObject && inventory.items.Count > 0)
                {
                    GameObject selectedItem = inventory.items[0];
                    playerInventory.AddItem(selectedItem);
                    inventory.RemoveItem(selectedItem);

                    selectedItem.transform.SetParent(player.transform, false);
                
                    
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            

             // Perform a raycast to detect the GameObject
            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                // Check if the raycast hit our GameObject
                if (hit.collider.gameObject == gameObject && playerInventory.items.Count > 0)
                {
                    GameObject selectedItem = playerInventory.items[0];
                    inventory.AddItem(selectedItem);
                    playerInventory.RemoveItem(selectedItem);

                    
                    selectedItem.transform.SetParent(gameObject.transform, false);

                }
            }

        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}
