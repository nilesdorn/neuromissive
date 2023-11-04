using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField]
    private TMP_Text enemyNameText;
    [SerializeField]
    private TMP_Text enemyHPText;
    private GameObject selectedEnemy;
    //public Transform goal;


    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            // Perform a raycast to detect the GameObject
            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

            
                if (clickedObject.CompareTag("Enemy"))
                {
                    // Display the enemy's name and HP in the UI
                    SelectEnemy(clickedObject);
                }
            }
        }
        else if (selectedEnemy != null && Input.GetKeyDown(KeyCode.Escape))
        {
            DeselectEnemy();
        }
    }
    void SelectEnemy(GameObject enemy)
    {
        // Set the selected enemy
        selectedEnemy = enemy;

        // Display enemy information in the UI
        enemyNameText.text = "Name: " + enemy.GetComponent<BaseEnemy>().enemyName;
        enemyHPText.text = "HP: " + enemy.GetComponent<BaseEnemy>().currentHP;
    }

    void DeselectEnemy()
    {
        // Deselect the enemy
        selectedEnemy = null;

        // Clear the displayed enemy information in the UI
        enemyNameText.text = "";
        enemyHPText.text = "";
    }

   
     // Function to handle the button press.
    public void Attack1()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 1");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }

    public void Attack2()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 2");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }

    public void Attack3()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 3");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }
    public void Attack4()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 4");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }

    public void Attack5()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 5");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }

    public void Attack6()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 6");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }

    public void Attack7()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 7");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }

    public void Attack8()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 8");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }

    public void Attack9()
    {
        if (selectedEnemy != null)
        {
            // Check if the selected enemy has an "EnemyStats" component with an HP variable.
            BaseEnemy baseEnemy = selectedEnemy.GetComponent<BaseEnemy>();
            if (baseEnemy != null)
            {
                // Reduce the enemy's HP by 10.
                baseEnemy.currentHP -= 10;
                Debug.Log("Attack 9");
                // Update the UI to display the updated HP.
                enemyHPText.text = "Enemy HP: " + baseEnemy.currentHP;

                // Check if the enemy's HP is now zero or below, and handle defeat if needed.
                if (baseEnemy.currentHP <= 0)
                {
                    // Handle enemy defeat logic (e.g., destroy the enemy, grant rewards, etc.).
                    Destroy(selectedEnemy);
                    DeselectEnemy();
                    Debug.Log("Enemy defeated");
                }
            }
        }
    }

}
