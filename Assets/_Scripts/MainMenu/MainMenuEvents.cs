using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenuEvents : MonoBehaviour
{
    private UIDocument _document;
    private Button _button;
    private List<Button> _menuButtons = new List<Button>();
    private AudioSource _audioSource;

    private VisualElement _settingsPanel;
    private VisualElement _controlsPanel;

    private Button _settingsBackButton;
    private Button _controlsBackButton;

    private VisualElement _currentOpenPanel;



    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        _document = GetComponent<UIDocument>();

        _button = _document.rootVisualElement.Q("Play") as Button;
        _button.RegisterCallback<ClickEvent>(OnPlayClick);

        _button = _document.rootVisualElement.Q("Settings") as Button;
        _button.RegisterCallback<ClickEvent>(OnSettingsClick);

        _button = _document.rootVisualElement.Q("Controls") as Button;
        _button.RegisterCallback<ClickEvent>(OnControlsClick);

        _settingsPanel = _document.rootVisualElement.Q("SettingsPanel");
        _controlsPanel = _document.rootVisualElement.Q("ControlsPanel");

        _settingsBackButton = _settingsPanel.Q<Button>("SettingsBackButton");
        _settingsBackButton.RegisterCallback<ClickEvent>(OnBackButtonClick);

        _controlsBackButton = _controlsPanel.Q<Button>("ControlsBackButton");
        _controlsBackButton.RegisterCallback<ClickEvent>(OnBackButtonClick);



        _menuButtons = _document.rootVisualElement.Query<Button>().ToList();
        for (int i = 0; i < _menuButtons.Count; i++)
        {
            _menuButtons[i].RegisterCallback<ClickEvent>(OnAllButtonClick);
        }

    }

    private void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(OnPlayClick);
        _button.UnregisterCallback<ClickEvent>(OnSettingsClick);
        _button.UnregisterCallback<ClickEvent>(OnControlsClick);

        _settingsBackButton.UnregisterCallback<ClickEvent>(OnBackButtonClick);
        _controlsBackButton.UnregisterCallback<ClickEvent>(OnBackButtonClick);


        for (int i = 0; i < _menuButtons.Count; i++)
        {
            _menuButtons[i].UnregisterCallback<ClickEvent>(OnAllButtonClick);
        }
    }

    private void OnPlayClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Play Button");
        // insert load next scene here / action here
    }

    private void OnSettingsClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Settings Button");
        // insert settings panel functionality



        CloseCurrentOpenPanel();

        if(_settingsPanel != null)
        {
            _settingsPanel.AddToClassList("moveSettingsPanelIntoFrame");
            _currentOpenPanel = _settingsPanel;
        }
    }

    private void OnControlsClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Controls Button");
        // insert Controls panel functionality

        CloseCurrentOpenPanel();

        if (_controlsPanel != null)
        {
            _controlsPanel.AddToClassList("moveControlsPanelIntoFrame");
            _currentOpenPanel = _controlsPanel;
        }
    }

    private void OnBackButtonClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Back Button");
        CloseCurrentOpenPanel();

    }

    private void CloseCurrentOpenPanel()
    {
        if (_currentOpenPanel != null)
        {
            _currentOpenPanel.RemoveFromClassList("moveSettingsPanelIntoFrame");
            _currentOpenPanel.RemoveFromClassList("moveControlsPanelIntoFrame");
            _currentOpenPanel = null;
        }
    }



    private void OnAllButtonClick(ClickEvent evt)
    {
        _audioSource.Play();
    }

}
