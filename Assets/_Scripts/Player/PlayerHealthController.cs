using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    /* 

    [SerializeField] private UIDocument winLoseEvents;
    [SerializeField] private VisualElement losePanel; 
    
    */

    [SerializeField] private GameObject losePanel;
    [SerializeField] private Button playAgainButton;
    private string mainMenu;


    private void Awake()
    {
        instance = this;
    }

    public float currentHealth, maxHealth;
    // public UnityEngine.UI.Slider healthSlider; (No longer using UI Elements - using the one below this)
    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
        losePanel.SetActive(false);
        /*  losePanel = winLoseEvents.rootVisualElement.Q<VisualElement>("LosePanel"); */
    }

    public void TakeDamage(float damageToTake)
    {
        Debug.Log("You got bitten");

        currentHealth -= damageToTake;
        healthSlider.value = currentHealth;

        // Check if health drops below zero
        if (currentHealth <= 0)
        {
            Debug.Log("spawn lose panel");
            losePanel.SetActive(true);
            /* ShowLosePanel(); *///This was a UI Element toolkit thing I strayed away from 
        }

    }
    public void OnPlayAgainButtonClicked()
    {
           Debug.Log("Play again button clicked");
           SceneManager.LoadScene(mainMenu);
    }

}


    // trying to get this to work, however multiple attempts not working. Going with plan B by adding in basic UI button - this is also attempted and referenced in WinLoseEvent script/ 

    /*
    private void ShowLosePanel()  

    {
        if (losePanel != null)
        {
            Debug.Log("add style to lose panel");
            losePanel.AddToClassList("MoveLosePanelIntoFrame");
        }
        else
        {
            Debug.LogError("losePanel is not assigned or could not be found.");
        }
    }
    */

