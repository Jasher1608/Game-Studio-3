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


    private VisualElement _aresSkillPopUp1;
    private VisualElement _aresSkillPopUp2;
    private VisualElement _aresSkillPopUp3;
    private VisualElement _aresSkillPopUp4;
    private VisualElement _aresSkillPopUp5;
    private VisualElement _aresSkillPopUp6;
    private VisualElement _aresSkillPopUp7;
    private VisualElement _aresSkillPopUp8;
    private VisualElement _aresSkillPopUp9;

    private Button _aresButton;
    private Button _apolloButton;
    private Button _dionysusButton;
    private Button _artemisButton;
    private Button _athenaButton;
    private Button _nyxButton;
    private Button _nemesisButton;

    private Button _aresBackButton;
    private Button _apolloBackButton;
    private Button _dionysusBackButton;
    private Button _artemisBackButton;
    private Button _athenaBackButton;
    private Button _nyxBackButton;
    private Button _nemesisBackButton;

    private Button _aresSkill1;
    private Button _aresSkill2;
    private Button _aresSkill3;
    private Button _aresSkill4;
    private Button _aresSkill5;
    private Button _aresSkill6;
    private Button _aresSkill7;
    private Button _aresSkill8;
    private Button _aresSkill9;

    private Button _apolloSkill1;
    private Button _apolloSkill2;
    private Button _apolloSkill3;
    private Button _apolloSkill4;
    private Button _apolloSkill5;
    private Button _apolloSkill6;
    private Button _apolloSkill7;
    private Button _apolloSkill8;
    private Button _apolloSkill9;

    private Button _dionysusSkill1;
    private Button _dionysusSkill2;
    private Button _dionysusSkill3;
    private Button _dionysusSkill4;
    private Button _dionysusSkill5;
    private Button _dionysusSkill6;
    private Button _dionysusSkill7;
    private Button _dionysusSkill8;
    private Button _dionysusSkill9;

    private Button _artemisSkill1;
    private Button _artemisSkill2;
    private Button _artemisSkill3;
    private Button _artemisSkill4;
    private Button _artemisSkill5;
    private Button _artemisSkill6;
    private Button _artemisSkill7;
    private Button _artemisSkill8;
    private Button _artemisSkill9;

    private Button _athenaSkill1;
    private Button _athenaSkill2;
    private Button _athenaSkill3;
    private Button _athenaSkill4;
    private Button _athenaSkill5;
    private Button _athenaSkill6;
    private Button _athenaSkill7;
    private Button _athenaSkill8;
    private Button _athenaSkill9;

    private Button _nemesisSkill1;
    private Button _nemesisSkill2;
    private Button _nemesisSkill3;
    private Button _nemesisSkill4;
    private Button _nemesisSkill5;
    private Button _nemesisSkill6;
    private Button _nemesisSkill7;
    private Button _nemesisSkill8;
    private Button _nemesisSkill9;

    private Button _nyxSkill1;
    private Button _nyxSkill2;
    private Button _nyxSkill3;
    private Button _nyxSkill4;
    private Button _nyxSkill5;
    private Button _nyxSkill6;
    private Button _nyxSkill7;
    private Button _nyxSkill8;
    private Button _nyxSkill9;

    private VisualElement _currentOpenPanel;

    private VisualElement _currentSkillPanel;


    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _document = GetComponent<UIDocument>();

        if (_document == null)
        {
            Debug.LogError("UIDocument component not found!");
            return;
        }

        InitializeButtons();
        InitializePanels();
        InitializeSkillButtons();
    }

    private void InitializeButtons()
    {
        _aresButton = InitializeButton("Ares", OnAresClick);
        _apolloButton = InitializeButton("Apollo", OnApolloClick);
        _dionysusButton = InitializeButton("Dionysus", OnDionysusClick);
        _artemisButton = InitializeButton("Artemis", OnArtemisClick);
        _athenaButton = InitializeButton("Athena", OnAthenaClick);
        _nemesisButton = InitializeButton("Nemesis", OnNemesisClick);
        _nyxButton = InitializeButton("Nyx", OnNyxClick);
    }

    private Button InitializeButton(string name, EventCallback<ClickEvent> callback)
    {
        Button button = _document.rootVisualElement.Q<Button>(name);
        if (button != null)
        {
            button.RegisterCallback<ClickEvent>(callback);
        }
        return button;
    }

    private void InitializePanels()
    {

        // Each god panel

        _aresPanel = _document.rootVisualElement.Q<VisualElement>("AresPanel");
        _apolloPanel = _document.rootVisualElement.Q<VisualElement>("ApolloPanel");
        _dionysusPanel = _document.rootVisualElement.Q<VisualElement>("DionysusPanel");
        _artemisPanel = _document.rootVisualElement.Q<VisualElement>("ArtemisPanel");
        _athenaPanel = _document.rootVisualElement.Q<VisualElement>("AthenaPanel");
        _nemesisPanel = _document.rootVisualElement.Q<VisualElement>("NemesisPanel");
        _nyxPanel = _document.rootVisualElement.Q<VisualElement>("NyxPanel");

        //Ares Skill Pop Up Panels

        _aresSkillPopUp1 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp1");
        _aresSkillPopUp2 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp2");
        _aresSkillPopUp3 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp3");
        _aresSkillPopUp4 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp4");
        _aresSkillPopUp5 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp5");
        _aresSkillPopUp6 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp6");
        _aresSkillPopUp7 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp7");
        _aresSkillPopUp8 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp8");
        _aresSkillPopUp9 = _document.rootVisualElement.Q<VisualElement>("AresSkillPopUp9");

        //Back button Panel return

        InitializeBackButton(_aresPanel, "AresBackButton");
        InitializeBackButton(_apolloPanel, "ApolloBackButton");
        InitializeBackButton(_dionysusPanel, "DionysusBackButton");
        InitializeBackButton(_artemisPanel, "ArtemisBackButton");
        InitializeBackButton(_athenaPanel, "AthenaBackButton");
        InitializeBackButton(_nemesisPanel, "NemesisBackButton");
        InitializeBackButton(_nyxPanel, "NyxBackButton");
    }

    private void InitializeBackButton(VisualElement panel, string buttonName)
    {
        if (panel != null)
        {
            Button backButton = panel.Q<Button>(buttonName);
            if (backButton != null)
            {
                backButton.RegisterCallback<ClickEvent>(OnBackButtonClick);
            }
        }
    }

    private void InitializeSkillButtons()
    {
        _aresSkill1 = InitializeButton("AresSkill1", OnAresSkill1Click);
        _aresSkill2 = InitializeButton("AresSkill2", OnAresSkill2Click);
        _aresSkill3 = InitializeButton("AresSkill3", OnAresSkill3Click);
        _aresSkill4 = InitializeButton("AresSkill4", OnAresSkill4Click);
        _aresSkill5 = InitializeButton("AresSkill5", OnAresSkill5Click);
        _aresSkill6 = InitializeButton("AresSkill6", OnAresSkill6Click);
        _aresSkill7 = InitializeButton("AresSkill7", OnAresSkill7Click);
        _aresSkill8 = InitializeButton("AresSkill8", OnAresSkill8Click);
        _aresSkill9 = InitializeButton("AresSkill9", OnAresSkill9Click);

        RegisterSkillButtonCallbacks();

    }

    private Button InitializeSkillButton(string name, EventCallback<ClickEvent> callback)
    {
        Button button = _document.rootVisualElement.Q<Button>(name);
        if (button != null)
        {
            button.RegisterCallback<ClickEvent>(callback);
        }
        return button;
    }


    // Register skill button callbacks

    private void RegisterSkillButtonCallbacks()
    {
        if (_aresSkill1 != null) _aresSkill1.RegisterCallback<ClickEvent>(OnAresSkill1Click);
        if (_aresSkill2 != null) _aresSkill2.RegisterCallback<ClickEvent>(OnAresSkill2Click);
        if (_aresSkill3 != null) _aresSkill3.RegisterCallback<ClickEvent>(OnAresSkill3Click);
        if (_aresSkill4 != null) _aresSkill4.RegisterCallback<ClickEvent>(OnAresSkill4Click);
        if (_aresSkill5 != null) _aresSkill5.RegisterCallback<ClickEvent>(OnAresSkill5Click);
        if (_aresSkill6 != null) _aresSkill6.RegisterCallback<ClickEvent>(OnAresSkill6Click);
        if (_aresSkill7 != null) _aresSkill7.RegisterCallback<ClickEvent>(OnAresSkill7Click);
        if (_aresSkill8 != null) _aresSkill8.RegisterCallback<ClickEvent>(OnAresSkill8Click);
        if (_aresSkill9 != null) _aresSkill9.RegisterCallback<ClickEvent>(OnAresSkill9Click);
    }

    
    private void OnDisable()
    {
        // upregister god panel buttons

        UnregisterButton(_aresButton, OnAresClick);
        UnregisterButton(_apolloButton, OnApolloClick);
        UnregisterButton(_dionysusButton, OnDionysusClick);
        UnregisterButton(_artemisButton, OnArtemisClick);
        UnregisterButton(_athenaButton, OnAthenaClick);
        UnregisterButton(_nemesisButton, OnNemesisClick);
        UnregisterButton(_nyxButton, OnNyxClick);

        // unregister ares skill buttons

        UnregisterSkillButton(_aresSkill1, OnAresSkill1Click);
        UnregisterSkillButton(_aresSkill2, OnAresSkill1Click);
        UnregisterSkillButton(_aresSkill3, OnAresSkill1Click);
        UnregisterSkillButton(_aresSkill4, OnAresSkill1Click);
        UnregisterSkillButton(_aresSkill5, OnAresSkill1Click);
        UnregisterSkillButton(_aresSkill6, OnAresSkill1Click);
        UnregisterSkillButton(_aresSkill7, OnAresSkill1Click);
        UnregisterSkillButton(_aresSkill8, OnAresSkill1Click);
        UnregisterSkillButton(_aresSkill9, OnAresSkill1Click);

        // Unregister god panel back buttons

        UnregisterBackButton(_aresBackButton, OnBackButtonClick);
        UnregisterBackButton(_apolloBackButton, OnBackButtonClick);
        UnregisterBackButton(_dionysusBackButton, OnBackButtonClick);
        UnregisterBackButton(_artemisBackButton, OnBackButtonClick);
        UnregisterBackButton(_athenaBackButton, OnBackButtonClick);
        UnregisterBackButton(_nemesisBackButton, OnBackButtonClick);
        UnregisterBackButton(_nyxBackButton, OnBackButtonClick);

        for (int i = 0; i < _skillTreeButtons.Count; i++)
        {
            _skillTreeButtons[i].UnregisterCallback<ClickEvent>(OnAllButtonClick);
        }
    }

    private void UnregisterButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }

    private void UnregisterSkillButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }

    private void UnregisterBackButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }

    private void OnAresClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Button");
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
        CloseCurrentOpenPanel();

        if (_apolloPanel != null)
        {
            _apolloPanel.AddToClassList("moveApolloPanelIntoFrame");
            _currentOpenPanel = _apolloPanel;
        }
    }

    private void OnDionysusClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Button");
        CloseCurrentOpenPanel();

        if (_dionysusPanel != null)
        {
            _dionysusPanel.AddToClassList("moveDionysusPanelIntoFrame");
            _currentOpenPanel = _dionysusPanel;
        }
    }

    private void OnArtemisClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Button");
        CloseCurrentOpenPanel();

        if (_artemisPanel != null)
        {
            _artemisPanel.AddToClassList("moveArtemisPanelIntoFrame");
            _currentOpenPanel = _artemisPanel;
        }
    }

    private void OnAthenaClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Button");
        CloseCurrentOpenPanel();

        if (_athenaPanel != null)
        {
            _athenaPanel.AddToClassList("moveAthenaPanelIntoFrame");
            _currentOpenPanel = _athenaPanel;
        }
    }

    private void OnNemesisClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Button");
        CloseCurrentOpenPanel();

        if (_nemesisPanel != null)
        {
            _nemesisPanel.AddToClassList("moveNemesisPanelIntoFrame");
            _currentOpenPanel = _nemesisPanel;
        }
    }

    private void OnNyxClick(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Button");
        CloseCurrentOpenPanel();

        if (_nyxPanel != null)
        {
            _nyxPanel.AddToClassList("moveNyxPanelIntoFrame");
            _currentOpenPanel = _nyxPanel;
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

    private void CloseCurrentSkillPanel()
    {
        if (_currentSkillPanel != null)
        {
            _currentSkillPanel.RemoveFromClassList("moveSkillPopUpPanelIntoFrame");
            _currentSkillPanel = null;
        }
    }


    private void OnAresSkill1Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 1 Button");
        _aresSkillPopUp1.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp1;
    }

    private void OnAresSkill2Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 2 Button");
        _aresSkillPopUp2.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp2;
    }

    private void OnAresSkill3Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 3 Button");
        _aresSkillPopUp3.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp3;

    }
    private void OnAresSkill4Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 4 Button");
        _aresSkillPopUp4.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp4;

    }

    private void OnAresSkill5Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 5 Button");
        _aresSkillPopUp4.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp5;

    }
    private void OnAresSkill6Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 6 Button");
        _aresSkillPopUp6.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp6;

    }
    private void OnAresSkill7Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 7 Button");
        _aresSkillPopUp7.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp7;
    }

    private void OnAresSkill8Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 8 Button");
        _aresSkillPopUp8.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp8;

    }
    private void OnAresSkill9Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 9 Button");
        _aresSkillPopUp9.AddToClassList("moveSkillPopUpPanelIntoFrame");

        _currentSkillPanel = _aresSkillPopUp9;
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
