using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkillTreeEvents : MonoBehaviour
{
    private UIDocument _document;
    private Button _button;

    private List<Button> _skillTreeButtons = new List<Button>();
    private AudioSource _audioSource;

    private VisualElement _aresPanel;
    private VisualElement _apolloPanel;
    private VisualElement _dionysusPanel;
    private VisualElement _artemisPanel;
    private VisualElement _athenaPanel;
    private VisualElement _nyxPanel;
    private VisualElement _nemesisPanel;

    private Button _aresBackButton;
    private Button _apolloBackButton;
    private Button _dionysusBackButton;
    private Button _artemisBackButton;
    private Button _athenaBackButton;
    private Button _nyxBackButton;
    private Button _nemesisBackButton;

    private VisualElement _currentOpenPanel;



    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _document = GetComponent<UIDocument>();

        _button = _document.rootVisualElement.Q("Ares") as Button;
        _button.RegisterCallback<ClickEvent>(OnAresClick);

        _button = _document.rootVisualElement.Q("Apollo") as Button;
        _button.RegisterCallback<ClickEvent>(OnApolloClick);

        _button = _document.rootVisualElement.Q("Dionysus") as Button;
        _button.RegisterCallback<ClickEvent>(OnContClick);

        _button = _document.rootVisualElement.Q("Artemis") as Button;
        _button.RegisterCallback<ClickEvent>(OnControlsClick);

        _button = _document.rootVisualElement.Q("Athena") as Button;
        _button.RegisterCallback<ClickEvent>(OnControlsClick);

        _button = _document.rootVisualElement.Q("Nemesis") as Button;
        _button.RegisterCallback<ClickEvent>(OnControlsClick);

        _button = _document.rootVisualElement.Q("Nyx") as Button;
        _button.RegisterCallback<ClickEvent>(OnControlsClick);


        _aresPanel = _document.rootVisualElement.Q("AresPanel");
        _apolloPanel = _document.rootVisualElement.Q("ApolloPanel");
        _dionysusPanel = _document.rootVisualElement.Q("DionysusPanel");
        _artemisPanel = _document.rootVisualElement.Q("ArtemisPanel");
        _athenaPanel = _document.rootVisualElement.Q("AthenaPanel");
        _nemesisPanel = _document.rootVisualElement.Q("NemesisPanel");
        _nyxPanel = _document.rootVisualElement.Q("NyxPanel");


        _aresBackButton = _aresPanel.Q<Button>("AresBackButton");
        _aresBackButton.RegisterCallback<ClickEvent>(OnBackButtonClick);

        _apolloBackButton = _apolloPanel.Q<Button>("ApolloBackButton");
        _apolloBackButton.RegisterCallback<ClickEvent>(OnBackButtonClick);

        _dionysusBackButton = _dionysusPanel.Q<Button>("DionysusBackButton");
        _dionysusBackButton.RegisterCallback<ClickEvent>(OnBackButtonClick);

        _artemisBackButton = _artemisPanel.Q<Button>("ArtemisBackButton");
        _artemisBackButton.RegisterCallback<ClickEvent>(OnBackButtonClick);

        _athenaBackButton = _athenaPanel.Q<Button>("AthenaBackButton");
        _athenaBackButton.RegisterCallback<ClickEvent>(OnBackButtonClick);

        _nemesisBackButton = _nemesisBackButton.Q<Button>("NemesisBackButton");
        _nemesisBackButton.RegisterCallback<ClickEvent> (OnBackButtonClick);

        _nyxBackButton = _nyxPanel.Q<Button>("NemesisBackButton");
        _nyxBackButton.RegisterCallback<ClickEvent>(OnBackButtonClick);


        UP TO HERE

       _buttons = _document.rootVisualElement.Query<Button>().ToList();
        for (int i = 0; i < _buttons.Count; i++)
        {
            _buttons[i].RegisterCallback<ClickEvent>(OnAllButtonClick);
        }

    }

    private void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(OnAresClick);
        _button.UnregisterCallback<ClickEvent>(OnApolloClick);
        _button.UnregisterCallback<ClickEvent>(OnArtemisClick);
        _button.UnregisterCallback<ClickEvent>(OnAthenaClick);
        _button.UnregisterCallback<ClickEvent>(OnNemesisClick);


        _settingsBackButton.UnregisterCallback<ClickEvent>(OnBackButtonClick);
        _controlsBackButton.UnregisterCallback<ClickEvent>(OnBackButtonClick);


        for (int i = 0; i < _menuButtons.Count; i++)
        {
            _menuButtons[i].UnregisterCallback<ClickEvent>(OnAllButtonClick);
        }
    }

    private void OnAresClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Button");
        // insert load next scene here / action here

        CloseCurrentOpenPanel();

        if (_aresPanel != null)
        {
            _aresPanel.AddToClassList("moveAresPanelIntoFrame");
            _currentOpenPanel = _aresPanel;
        }
    }

    private void OnApolloClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Button");
        // insert settings panel functionality

        CloseCurrentOpenPanel();

        if (_apolloPanel != null)
        {
            _apolloPanel.AddToClassList("moveApolloPanelIntoFrame");
            _currentOpenPanel = _apolloPanel;
        }
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
                _currentOpenPanel.RemoveFromClassList("moveAresPanelIntoFrame");
                _currentOpenPanel.RemoveFromClassList("moveApolloPanelIntoFrame");
                _currentOpenPanel.RemoveFromClassList("moveDionysusPanelIntoFrame");
                _currentOpenPanel.RemoveFromClassList("moveAthenaPanelIntoFrame");
                _currentOpenPanel.RemoveFromClassList("moveArtemisPanelIntoFrame");
                _currentOpenPanel.RemoveFromClassList("moveNyxPanelIntoFrame");
                _currentOpenPanel.RemoveFromClassList("moveNemesisPanelIntoFrame");

                _currentOpenPanel = null;
            }
    }


    private void OnAllButtonClick(ClickEvent evt)
    {
        _audioSource.Play();
    }

}


// STARTED AGAIN TO ALIGN WITH NEW SKILL TREE DESIGN - 19 July 2024 



//using Sirenix.OdinInspector;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UIElements;

//public class SkillTreeEvents : SerializedMonoBehaviour
//{
//    private UIDocument _document;

//    #region Button References
//    private Button _buttonAres;
//    private Button _buttonApollo;
//    private Button _buttonDionysus;
//    private Button _buttonArtemis;
//    private Button _buttonAthena;
//    private Button _buttonNemesis;
//    private Button _buttonNyx;
//    private Button _buttonTheFates;

//    private Button _buttonAresSkill1;
//    private Button _buttonAresSkill2;
//    private Button _buttonAresSkill3;
//    private Button _buttonAresSkill4;
//    private Button _buttonAresSkill5;
//    private Button _buttonAresSkill6;
//    private Button _buttonAresSkill7;
//    private Button _buttonAresSkill8;
//    private Button _buttonAresSkill9;
//    #endregion Button References

//    private Label _xpLabel;

//    private List<Button> _skillTreeButtons = new List<Button>();

//    private AudioSource _audioSource;

//    private PlayerController _playerController;
//    public ExperienceManager experienceManager;
//    public SkillManager skillManager;

//    [SerializeField] private SkillTree _aresSkillTree;

//    // TODO: Change this to use a dictionary, and include all gods
//    [Header("Gods")]
//    [SerializeField] private Dictionary<string, God> gods = new Dictionary<string, God>();

//    private void OnEnable()
//    {
//        _audioSource = GetComponent<AudioSource>();
//        _document = GetComponent<UIDocument>();
//        _playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();

//        #region Button Assignments
//        _buttonAres = _document.rootVisualElement.Q<Button>("Ares");
//        _buttonApollo = _document.rootVisualElement.Q<Button>("Apollo");
//        _buttonDionysus = _document.rootVisualElement.Q<Button>("Dionysus");
//        _buttonArtemis = _document.rootVisualElement.Q<Button>("Artemis");
//        _buttonAthena = _document.rootVisualElement.Q<Button>("Athena");
//        _buttonNemesis = _document.rootVisualElement.Q<Button>("Nemesis");
//        _buttonNyx = _document.rootVisualElement.Q<Button>("Nyx");
//        _buttonTheFates = _document.rootVisualElement.Q<Button>("TheFates");

//        _buttonAresSkill1 = _document.rootVisualElement.Q<Button>("AresSkill1");
//        _buttonAresSkill2 = _document.rootVisualElement.Q<Button>("AresSkill2");
//        _buttonAresSkill3 = _document.rootVisualElement.Q<Button>("AresSkill3");
//        _buttonAresSkill4 = _document.rootVisualElement.Q<Button>("AresSkill4");
//        _buttonAresSkill5 = _document.rootVisualElement.Q<Button>("AresSkill5");
//        _buttonAresSkill6 = _document.rootVisualElement.Q<Button>("AresSkill6");
//        _buttonAresSkill7 = _document.rootVisualElement.Q<Button>("AresSkill7");
//        _buttonAresSkill8 = _document.rootVisualElement.Q<Button>("AresSkill8");
//        _buttonAresSkill9 = _document.rootVisualElement.Q<Button>("AresSkill9");
//        #endregion Button Assignments
//        _xpLabel = _document.rootVisualElement.Q<Label>("XP");
//        _xpLabel.text = $"XP: {experienceManager.currentGodInstance.currentXP:F1}/{experienceManager.currentGodInstance.xpToNextLevel:F1}";

//        #region Register Buttons
//        // God Buttons
//        RegisterButtonCallback(_buttonAres, "Ares");
//        RegisterButtonCallback(_buttonApollo, "Apollo");
//        RegisterButtonCallback(_buttonDionysus, "Dionysus");
//        RegisterButtonCallback(_buttonArtemis, "Artemis");
//        RegisterButtonCallback(_buttonAthena, "Athena");
//        RegisterButtonCallback(_buttonNemesis, "Nemesis");
//        RegisterButtonCallback(_buttonNyx, "Nyx");
//        RegisterButtonCallback(_buttonTheFates, "TheFates");

//        // Skill Buttons
//        RegisterButtonCallback(_buttonAresSkill1, "AresSkill1");
//        RegisterButtonCallback(_buttonAresSkill2, "AresSkill2");
//        RegisterButtonCallback(_buttonAresSkill3, "AresSkill3");
//        RegisterButtonCallback(_buttonAresSkill4, "AresSkill4");
//        RegisterButtonCallback(_buttonAresSkill5, "AresSkill5");
//        RegisterButtonCallback(_buttonAresSkill6, "AresSkill6");
//        RegisterButtonCallback(_buttonAresSkill7, "AresSkill7");
//        RegisterButtonCallback(_buttonAresSkill8, "AresSkill8");
//        RegisterButtonCallback(_buttonAresSkill9, "AresSkill9");
//        #endregion Register Buttons

//        _skillTreeButtons = _document.rootVisualElement.Query<Button>().ToList(); 

//        for (int i = 0; i < _skillTreeButtons.Count; i++)
//        {
//            _skillTreeButtons[i].RegisterCallback<ClickEvent>(OnAllButtonsClick);
//        }

//    }    
//    private void RegisterButtonCallback(Button button, string buttonName)

//    {
//            if (button != null)
//            {
//                button.RegisterCallback<ClickEvent>(evt => OnButtonClick(evt, buttonName));
//            }
//            else
//            {
//                Debug.LogError($"Button with name '{buttonName}' not found or is not of type Button.");
//            }
//    }

//    private void OnButtonClick(ClickEvent evt, string buttonName)
//    {
//        if (gods.TryGetValue(buttonName, out God god))
//        {
//            _playerController.ChangeGod(god);
//            _xpLabel.text = $"XP: {experienceManager.currentGodInstance.currentXP:F1}/{experienceManager.currentGodInstance.xpToNextLevel:F1}";
//        }

//        switch (buttonName)
//        {
//            case "AresSkill1":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[0], PlayerController.playerStats);
//                break;
//            case "AresSkill2":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[1], PlayerController.playerStats);
//                break;
//            case "AresSkill3":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[2], PlayerController.playerStats);
//                break;
//            case "AresSkill4":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[3], PlayerController.playerStats);
//                break;
//            case "AresSkill5":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[4], PlayerController.playerStats);
//                break;
//            case "AresSkill6":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[5], PlayerController.playerStats);
//                break;
//            case "AresSkill7":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[6], PlayerController.playerStats);
//                break;
//            case "AresSkill8":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[7], PlayerController.playerStats);
//                break;
//            case "AresSkill9":
//                skillManager.UpgradeSkill(_aresSkillTree.skills[8], PlayerController.playerStats);
//                break;
//        }
//    }

//    private void OnDisable()
//    {
//        //_button.UnregisterCallback<ClickEvent>(OnPlayGameClick);

//        for (int i = 0; i < _skillTreeButtons.Count;i++)
//        {
//            _skillTreeButtons[i].UnregisterCallback<ClickEvent>(OnAllButtonsClick);
//        }
//    }

//    private void OnAllButtonsClick(ClickEvent evt)
//    {
//        _audioSource.Play();
//    }
//}
