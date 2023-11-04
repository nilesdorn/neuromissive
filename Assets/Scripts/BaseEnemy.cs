using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    [SerializeField]
    public string enemyID;
    [SerializeField]
    public string enemyName;
    [SerializeField]
    public int hitPoints;
    [SerializeField]
    public int currentHP;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private Material baseMaterial;
    [SerializeField]
    private Material highlightMaterial;
    public Transform myTransform;
    public Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = myTransform.position;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            HighlightEnemy(ray, hit);
        }
        
    }

    public void HighlightEnemy(Ray ray, RaycastHit hit)
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
