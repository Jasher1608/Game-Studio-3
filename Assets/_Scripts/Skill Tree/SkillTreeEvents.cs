using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkillTreeEvents : SerializedMonoBehaviour
{
    private UIDocument _document;

    private Button _buttonAres;
    private Button _buttonApollo;
    private Button _buttonDionysus;
    private Button _buttonArtemis;
    private Button _buttonAthena;
    private Button _buttonNemesis;
    private Button _buttonNyx;
    private Button _buttonTheFates;

    private Label _xpLabel;

    private List<Button> _skillTreeButtons = new List<Button>();

    private AudioSource _audioSource;

    private PlayerController _playerController;
    public ExperienceManager experienceManager;

    // TODO: Change this to use a dictionary, and include all gods
    [Header("Gods")]
    [SerializeField] private Dictionary<string, God> gods = new Dictionary<string, God>();

    private void OnEnable()
    {
        _audioSource = GetComponent<AudioSource>();
        _document = GetComponent<UIDocument>();
        _playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

        _buttonAres = _document.rootVisualElement.Q<Button>("Ares");
        _buttonApollo = _document.rootVisualElement.Q<Button>("Apollo");
        _buttonDionysus = _document.rootVisualElement.Q<Button>("Dionysus");
        _buttonArtemis = _document.rootVisualElement.Q<Button>("Artemis");
        _buttonAthena = _document.rootVisualElement.Q<Button>("Athena");
        _buttonNemesis = _document.rootVisualElement.Q<Button>("Nemesis");
        _buttonNyx = _document.rootVisualElement.Q<Button>("Nyx");
        _buttonTheFates = _document.rootVisualElement.Q<Button>("TheFates");
        _xpLabel = _document.rootVisualElement.Q<Label>("XP");
        _xpLabel.text = $"XP: {experienceManager.currentGodInstance.currentXP:F1}/{experienceManager.currentGodInstance.xpToNextLevel:F1}";

        RegisterButtonCallback(_buttonAres, "Ares");
        RegisterButtonCallback(_buttonApollo, "Apollo");
        RegisterButtonCallback(_buttonDionysus, "Dionysus");
        RegisterButtonCallback(_buttonArtemis, "Artemis");
        RegisterButtonCallback(_buttonAthena, "Athena");
        RegisterButtonCallback(_buttonNemesis, "Nemesis");
        RegisterButtonCallback(_buttonNyx, "Nyx");
        RegisterButtonCallback(_buttonTheFates, "TheFates");

        _skillTreeButtons = _document.rootVisualElement.Query<Button>().ToList(); 

        for (int i = 0; i < _skillTreeButtons.Count; i++)
        {
            _skillTreeButtons[i].RegisterCallback<ClickEvent>(OnAllButtonsClick);
        }

    }    
    private void RegisterButtonCallback(Button button, string buttonName)
        
    {
            if (button != null)
            {
                button.RegisterCallback<ClickEvent>(evt => OnButtonClick(evt, buttonName));
            }
            else
            {
                Debug.LogError($"Button with name '{buttonName}' not found or is not of type Button.");
            }
    }

    private void OnButtonClick(ClickEvent evt, string buttonName)
    {
        if (gods.TryGetValue(buttonName, out God god))
        {
            _playerController.ChangeGod(god);
            _xpLabel.text = $"XP: {experienceManager.currentGodInstance.currentXP:F1}/{experienceManager.currentGodInstance.xpToNextLevel:F1}";
        }
    }

    private void OnDisable()
    {
        //_button.UnregisterCallback<ClickEvent>(OnPlayGameClick);

        for (int i = 0; i < _skillTreeButtons.Count;i++)
        {
            _skillTreeButtons[i].UnregisterCallback<ClickEvent>(OnAllButtonsClick);
        }
    }
    
    private void OnAllButtonsClick(ClickEvent evt)
    {
        _audioSource.Play();
    }
}
