using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkillTreeEvents : SerializedMonoBehaviour
{
    private UIDocument _document;

    #region Button References
    private Button _buttonAres;
    private Button _buttonApollo;
    private Button _buttonDionysus;
    private Button _buttonArtemis;
    private Button _buttonAthena;
    private Button _buttonNemesis;
    private Button _buttonNyx;
    private Button _buttonTheFates;

    private Button _buttonAresSkill1;
    private Button _buttonAresSkill2;
    private Button _buttonAresSkill3;
    private Button _buttonAresSkill4;
    private Button _buttonAresSkill5;
    private Button _buttonAresSkill6;
    private Button _buttonAresSkill7;
    private Button _buttonAresSkill8;
    private Button _buttonAresSkill9;
    #endregion Button References

    private Label _xpLabel;

    private List<Button> _skillTreeButtons = new List<Button>();

    private AudioSource _audioSource;

    private PlayerController _playerController;
    public ExperienceManager experienceManager;
    public SkillManager skillManager;

    [SerializeField] private SkillTree _aresSkillTree;

    // TODO: Change this to use a dictionary, and include all gods
    [Header("Gods")]
    [SerializeField] private Dictionary<string, God> gods = new Dictionary<string, God>();

    private void OnEnable()
    {
        _audioSource = GetComponent<AudioSource>();
        _document = GetComponent<UIDocument>();
        _playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

        #region Button Assignments
        _buttonAres = _document.rootVisualElement.Q<Button>("Ares");
        _buttonApollo = _document.rootVisualElement.Q<Button>("Apollo");
        _buttonDionysus = _document.rootVisualElement.Q<Button>("Dionysus");
        _buttonArtemis = _document.rootVisualElement.Q<Button>("Artemis");
        _buttonAthena = _document.rootVisualElement.Q<Button>("Athena");
        _buttonNemesis = _document.rootVisualElement.Q<Button>("Nemesis");
        _buttonNyx = _document.rootVisualElement.Q<Button>("Nyx");
        _buttonTheFates = _document.rootVisualElement.Q<Button>("TheFates");

        _buttonAresSkill1 = _document.rootVisualElement.Q<Button>("AresSkill1");
        _buttonAresSkill2 = _document.rootVisualElement.Q<Button>("AresSkill2");
        _buttonAresSkill3 = _document.rootVisualElement.Q<Button>("AresSkill3");
        _buttonAresSkill4 = _document.rootVisualElement.Q<Button>("AresSkill4");
        _buttonAresSkill5 = _document.rootVisualElement.Q<Button>("AresSkill5");
        _buttonAresSkill6 = _document.rootVisualElement.Q<Button>("AresSkill6");
        _buttonAresSkill7 = _document.rootVisualElement.Q<Button>("AresSkill7");
        _buttonAresSkill8 = _document.rootVisualElement.Q<Button>("AresSkill8");
        _buttonAresSkill9 = _document.rootVisualElement.Q<Button>("AresSkill9");
        #endregion Button Assignments
        _xpLabel = _document.rootVisualElement.Q<Label>("XP");
        _xpLabel.text = $"XP: {experienceManager.currentGodInstance.currentXP:F1}/{experienceManager.currentGodInstance.xpToNextLevel:F1}";

        #region Register Buttons
        // God Buttons
        RegisterButtonCallback(_buttonAres, "Ares");
        RegisterButtonCallback(_buttonApollo, "Apollo");
        RegisterButtonCallback(_buttonDionysus, "Dionysus");
        RegisterButtonCallback(_buttonArtemis, "Artemis");
        RegisterButtonCallback(_buttonAthena, "Athena");
        RegisterButtonCallback(_buttonNemesis, "Nemesis");
        RegisterButtonCallback(_buttonNyx, "Nyx");
        RegisterButtonCallback(_buttonTheFates, "TheFates");

        // Skill Buttons
        RegisterButtonCallback(_buttonAresSkill1, "AresSkill1");
        RegisterButtonCallback(_buttonAresSkill2, "AresSkill2");
        RegisterButtonCallback(_buttonAresSkill3, "AresSkill3");
        RegisterButtonCallback(_buttonAresSkill4, "AresSkill4");
        RegisterButtonCallback(_buttonAresSkill5, "AresSkill5");
        RegisterButtonCallback(_buttonAresSkill6, "AresSkill6");
        RegisterButtonCallback(_buttonAresSkill7, "AresSkill7");
        RegisterButtonCallback(_buttonAresSkill8, "AresSkill8");
        RegisterButtonCallback(_buttonAresSkill9, "AresSkill9");
        #endregion Register Buttons

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

        switch (buttonName)
        {
            case "AresSkill1":
                skillManager.UpgradeSkill(_aresSkillTree.skills[0], PlayerController.playerStats);
                break;
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
