using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : MonoBehaviour
{
    [SerializeField]
    private Material baseMaterial;
    [SerializeField]
    private Material highlightMaterial;
    public string itemName;
    public int itemID;
    public Sprite itemIcon;
    public int itemValue;

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
            HighlightItem(ray, hit);
        }
        
    }

    public void HighlightItem(Ray ray, RaycastHit hit)
    {
        
        GameObject hitObject = hit.collider.gameObject;
            
        // Check if the hit object is the one you want to highlight
        if (hitObject == gameObject)
        {
            MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
            // Apply the highlight material
            renderer.material = highlightMaterial;
        }

        else
        {
            MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
            renderer.material = baseMaterial;
        }
    }

}
