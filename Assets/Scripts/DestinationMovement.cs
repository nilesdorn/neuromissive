using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class DestinationMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public GameObject destinationIndicatorPrefab; // Assign the destination indicator prefab in the Inspector.
    private GameObject activeIndicator; // Reference to the currently active indicator.

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the click did not occur over a UI element.
            if (!IsPointerOverUIElement())
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    // Remove the active indicator if one exists.
                    if (activeIndicator != null)
                    {
                        RemoveIndicator(activeIndicator);
                    }

                    // Move the player character to the clicked position.
                    navMeshAgent.SetDestination(hit.point);

                    // Place the new destination indicator at the clicked position.
                    activeIndicator = Instantiate(destinationIndicatorPrefab);
                    activeIndicator.GetComponent<DestinationIndicator>().PlaceIndicator(hit.point);
                }
            }
        }
    }

    private void RemoveIndicator(GameObject indicator)
    {
        // Remove the indicator by disabling it or destroying it.
        Destroy(indicator); // Destroying the GameObject.
    }

    private bool IsPointerOverUIElement()
    {
        return EventSystem.current.IsPointerOverGameObject() && EventSystem.current.currentSelectedGameObject.layer == LayerMask.NameToLayer("UI");
    }
}
