using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class WinLoseEvents : MonoBehaviour
{
    private UIDocument _document;

    private VisualElement _losePanel;
    private VisualElement _winPanel;

    private Button _playAgainButton;
    private Button _nextLevelButton;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();

        if (_document == null)
        {
            Debug.LogError("UIDocument component not found!");
            return;
        }

        InitializePanels();
        InitializeButtons();
    }

    private void InitializeButtons()
    {
        _playAgainButton = _document.rootVisualElement.Q<Button>("PlayAgain");
        _nextLevelButton = _document.rootVisualElement.Q<Button>("NextLevel");

        if (_playAgainButton != null)
        {
            _playAgainButton.RegisterCallback<ClickEvent>(OnPlayAgainClick);
        }

        if (_nextLevelButton != null)
        {
            _nextLevelButton.RegisterCallback<ClickEvent>(OnNextLevelClick);
        }
    }

    private void InitializePanels()
    {
        _losePanel = _document.rootVisualElement.Q<VisualElement>("LosePanel");
        _winPanel = _document.rootVisualElement.Q<VisualElement>("WinPanel");
    }

    private void OnDisable()
    {
        UnregisterButton(_playAgainButton, OnPlayAgainClick);
        UnregisterButton(_nextLevelButton, OnNextLevelClick);
    }

    private void UnregisterButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }

    private void OnPlayAgainClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Play Again button");

        SceneManager.LoadScene("MainMenu");
    }

    private void OnNextLevelClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Next Level button");

        // Insert next level when created 
        // SceneManager.LoadScene("Tarturus");
    }
}
