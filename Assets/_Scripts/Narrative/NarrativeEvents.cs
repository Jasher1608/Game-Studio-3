using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NarrativeEvents : MonoBehaviour
{
    private UIDocument _document;

    private Button _nextButtonFive;
    private Button _nextButtonSix;
    private Button _nextButtonSeven;
    private Button _nextButtonClose;

    private Label _narrativeFive;
    private Label _narrativeSix;
    private Label _narrativeSeven;
    private Label _narrativeEight;

    private VisualElement _containerGameNarrativeTwoPanel;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();

        // Initialize buttons
        _nextButtonFive = _document.rootVisualElement.Q<Button>("NextButtonFive");
        _nextButtonSix = _document.rootVisualElement.Q<Button>("NextButtonSix");
        _nextButtonSeven = _document.rootVisualElement.Q<Button>("NextButtonSeven");
        _nextButtonClose = _document.rootVisualElement.Q<Button>("NextButtonClose");

        // Register callbacks
        _nextButtonFive?.RegisterCallback<ClickEvent>(OnNextButtonFiveClick);
        _nextButtonSix?.RegisterCallback<ClickEvent>(OnNextButtonSixClick);
        _nextButtonSeven?.RegisterCallback<ClickEvent>(OnNextButtonSevenClick);
        _nextButtonClose?.RegisterCallback<ClickEvent>(OnNextButtonCloseClick);

        // Initialize panels
        _containerGameNarrativeTwoPanel = _document.rootVisualElement.Q<VisualElement>("ContainerGameNarrativeTwoPanel");

        // Initialize Labels
        _narrativeFive = _document.rootVisualElement.Q<Label>("NarrativeFive");
        _narrativeSix = _document.rootVisualElement.Q<Label>("NarrativeSix");
        _narrativeSeven = _document.rootVisualElement.Q<Label>("NarrativeSeven");
        _narrativeEight = _document.rootVisualElement.Q<Label>("NarrativeEight");

        Time.timeScale = 0; // Pause the game
        // note : this is not working - still troubleshooting 
    }

    private void OnDisable()
    {
        // Unregister button callbacks
        UnregisterButtonCallbacks1();
    }

    private void UnregisterButtonCallbacks1()
    {
        if (_nextButtonFive != null) _nextButtonFive.UnregisterCallback<ClickEvent>(OnNextButtonFiveClick);
        if (_nextButtonSix != null) _nextButtonSix.UnregisterCallback<ClickEvent>(OnNextButtonSixClick);
        if (_nextButtonSeven != null) _nextButtonSeven.UnregisterCallback<ClickEvent>(OnNextButtonSevenClick);
        if (_nextButtonClose != null) _nextButtonClose.UnregisterCallback<ClickEvent>(OnNextButtonCloseClick);
    }

    private void OnNextButtonFiveClick(ClickEvent evt)
    {
        Debug.Log("You pressed the first next Button");

        // Update narrative label
        if (_narrativeFive != null) // Ensure label is not null
        {
            _narrativeFive.AddToClassList("makeInvisible"); // Add class to make invisible
        }
        if (_narrativeSix != null) // Ensure label is not null
        {
            _narrativeSix.AddToClassList("insertTextBoxTwo"); // Add class to show next narrative
        }
    }

    private void OnNextButtonSixClick(ClickEvent evt)
    {
        // Update narrative label
        if (_narrativeSix != null) // Ensure label is not null
        {
            _narrativeSix.AddToClassList("makeInvisible"); // Add class to make invisible
        }
        if (_narrativeSeven != null) // Ensure label is not null
        {
            _narrativeSeven.AddToClassList("insertTextBoxThree"); // Add class to show next narrative
        }
    }

    public void OnNextButtonSevenClick(ClickEvent evt)
    {
        // Update narrative label
        if (_narrativeSeven != null) // Ensure label is not null
        {
            _narrativeSeven.AddToClassList("makeInvisible"); // Add class to make invisible
        }
        if (_narrativeEight != null) // Ensure label is not null
        {
            _narrativeEight.AddToClassList("insertTextBoxFour"); // Add class to show next narrative
        }
    }

    private void OnNextButtonCloseClick(ClickEvent evt)
    {
        Debug.Log("You pressed the next close Button");

        // Close narrative panel and resume the game
        if (_containerGameNarrativeTwoPanel != null)
        {
            _containerGameNarrativeTwoPanel.style.display = DisplayStyle.None; // Hide the panel
            Time.timeScale = 1; // Resume the game 

            // note : this is not working - still troubleshooting - just kidding got it to work today 16.8.24
        }
    }
}
