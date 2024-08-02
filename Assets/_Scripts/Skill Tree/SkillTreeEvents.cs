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

    private VisualElement _apolloSkillPopUp1;
    private VisualElement _apolloSkillPopUp2;
    private VisualElement _apolloSkillPopUp3;
    private VisualElement _apolloSkillPopUp4;
    private VisualElement _apolloSkillPopUp5;
    private VisualElement _apolloSkillPopUp6;
    private VisualElement _apolloSkillPopUp7;
    private VisualElement _apolloSkillPopUp8;
    private VisualElement _apolloSkillPopUp9;

    private VisualElement _dionysusSkillPopUp1;
    private VisualElement _dionysusSkillPopUp2;
    private VisualElement _dionysusSkillPopUp3;
    private VisualElement _dionysusSkillPopUp4;
    private VisualElement _dionysusSkillPopUp5;
    private VisualElement _dionysusSkillPopUp6;
    private VisualElement _dionysusSkillPopUp7;
    private VisualElement _dionysusSkillPopUp8;
    private VisualElement _dionysusSkillPopUp9;

    private VisualElement _artemisSkillPopUp1;
    private VisualElement _artemisSkillPopUp2;
    private VisualElement _artemisSkillPopUp3;
    private VisualElement _artemisSkillPopUp4;
    private VisualElement _artemisSkillPopUp5;
    private VisualElement _artemisSkillPopUp6;
    private VisualElement _artemisSkillPopUp7;
    private VisualElement _artemisSkillPopUp8;
    private VisualElement _artemisSkillPopUp9;

    private VisualElement _athenaSkillPopUp1;
    private VisualElement _athenaSkillPopUp2;
    private VisualElement _athenaSkillPopUp3;
    private VisualElement _athenaSkillPopUp4;
    private VisualElement _athenaSkillPopUp5;
    private VisualElement _athenaSkillPopUp6;
    private VisualElement _athenaSkillPopUp7;
    private VisualElement _athenaSkillPopUp8;
    private VisualElement _athenaSkillPopUp9;

    private VisualElement _nemesisSkillPopUp1;
    private VisualElement _nemesisSkillPopUp2;
    private VisualElement _nemesisSkillPopUp3;
    private VisualElement _nemesisSkillPopUp4;
    private VisualElement _nemesisSkillPopUp5;
    private VisualElement _nemesisSkillPopUp6;
    private VisualElement _nemesisSkillPopUp7;
    private VisualElement _nemesisSkillPopUp8;
    private VisualElement _nemesisSkillPopUp9;

    private VisualElement _nyxSkillPopUp1;
    private VisualElement _nyxSkillPopUp2;  
    private VisualElement _nyxSkillPopUp3;
    private VisualElement _nyxSkillPopUp4;
    private VisualElement _nyxSkillPopUp5;
    private VisualElement _nyxSkillPopUp6;
    private VisualElement _nyxSkillPopUp7;
    private VisualElement _nyxSkillPopUp8;
    private VisualElement _nyxSkillPopUp9;


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

    private VisualElement _currentAresSkillPanel;
    private VisualElement _currentApolloSkillPanel;
    private VisualElement _currentDionysusSkillPanel;
    private VisualElement _currentArtemisSkillPanel;
    private VisualElement _currentAthenaSkillPanel;
    private VisualElement _currentNemesisSkillPanel;
    private VisualElement _currentNyxSkillPanel;


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

        //Apollo Skill Pop Up Panels

        _apolloSkillPopUp1 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp1");
        _apolloSkillPopUp2 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp2");
        _apolloSkillPopUp3 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp3");
        _apolloSkillPopUp4 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp4");
        _apolloSkillPopUp5 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp5");
        _apolloSkillPopUp6 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp6");
        _apolloSkillPopUp7 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp7");
        _apolloSkillPopUp8 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp8");
        _apolloSkillPopUp9 = _document.rootVisualElement.Q<VisualElement>("ApolloSkillPopUp9");

        //Dionysus Skill Pop Up Panels

        _dionysusSkillPopUp1 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp1");
        _dionysusSkillPopUp2 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp2");
        _dionysusSkillPopUp3 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp3");
        _dionysusSkillPopUp4 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp4");
        _dionysusSkillPopUp5 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp5");
        _dionysusSkillPopUp6 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp6");
        _dionysusSkillPopUp7 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp7");
        _dionysusSkillPopUp8 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp8");
        _dionysusSkillPopUp9 = _document.rootVisualElement.Q<VisualElement>("DionysusSkillPopUp9");

        //Artemis Skill Pop Up Panels

        _artemisSkillPopUp1 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp1");
        _artemisSkillPopUp2 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp2");
        _artemisSkillPopUp3 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp3");
        _artemisSkillPopUp4 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp4");
        _artemisSkillPopUp5 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp5");
        _artemisSkillPopUp6 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp6");
        _artemisSkillPopUp7 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp7");
        _artemisSkillPopUp8 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp8");
        _artemisSkillPopUp9 = _document.rootVisualElement.Q<VisualElement>("ArtemisSkillPopUp9");

        //Athena Skill Pop Up Panels

        _athenaSkillPopUp1 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp1");
        _athenaSkillPopUp2 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp2");
        _athenaSkillPopUp3 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp3");
        _athenaSkillPopUp4 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp4");
        _athenaSkillPopUp5 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp5");
        _athenaSkillPopUp6 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp6");
        _athenaSkillPopUp7 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp7");
        _athenaSkillPopUp8 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp8");
        _athenaSkillPopUp9 = _document.rootVisualElement.Q<VisualElement>("AthenaSkillPopUp9");


        //Nemesis Skill Pop Up Panels

        _nemesisSkillPopUp1 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp1");
        _nemesisSkillPopUp2 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp2");
        _nemesisSkillPopUp3 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp3");
        _nemesisSkillPopUp4 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp4");
        _nemesisSkillPopUp5 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp5");
        _nemesisSkillPopUp6 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp6");
        _nemesisSkillPopUp7 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp7");
        _nemesisSkillPopUp8 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp8");
        _nemesisSkillPopUp9 = _document.rootVisualElement.Q<VisualElement>("NemesisSkillPopUp9");

        //Nyx Skill Pop Up Panels

        _nyxSkillPopUp1 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp1");
        _nyxSkillPopUp2 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp2");
        _nyxSkillPopUp3 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp3");
        _nyxSkillPopUp4 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp4");
        _nyxSkillPopUp5 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp5");
        _nyxSkillPopUp6 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp6");
        _nyxSkillPopUp7 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp7");
        _nyxSkillPopUp8 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp8");
        _nyxSkillPopUp9 = _document.rootVisualElement.Q<VisualElement>("NyxSkillPopUp9");

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


        _apolloSkill1 = InitializeButton("ApolloSkill1", OnApolloSkill1Click);
        _apolloSkill2 = InitializeButton("ApolloSkill2", OnApolloSkill2Click);
        _apolloSkill3 = InitializeButton("ApolloSkill3", OnApolloSkill3Click);
        _apolloSkill4 = InitializeButton("ApolloSkill4", OnApolloSkill4Click);
        _apolloSkill5 = InitializeButton("ApolloSkill5", OnApolloSkill5Click);
        _apolloSkill6 = InitializeButton("ApolloSkill6", OnApolloSkill6Click);
        _apolloSkill7 = InitializeButton("ApolloSkill7", OnApolloSkill7Click);
        _apolloSkill8 = InitializeButton("ApolloSkill8", OnApolloSkill8Click);
        _apolloSkill9 = InitializeButton("ApolloSkill9", OnApolloSkill9Click);

        _dionysusSkill1 = InitializeButton("DionysusSkill1", OnDionysusSkill1Click);
        _dionysusSkill2 = InitializeButton("DionysusSkill2", OnDionysusSkill2Click);
        _dionysusSkill3 = InitializeButton("DionysusSkill3", OnDionysusSkill3Click);
        _dionysusSkill4 = InitializeButton("DionysusSkill4", OnDionysusSkill4Click);
        _dionysusSkill5 = InitializeButton("DionysusSkill5", OnDionysusSkill5Click);
        _dionysusSkill6 = InitializeButton("DionysusSkill6", OnDionysusSkill6Click);
        _dionysusSkill7 = InitializeButton("DionysusSkill7", OnDionysusSkill7Click);
        _dionysusSkill8 = InitializeButton("DionysusSkill8", OnDionysusSkill8Click);
        _dionysusSkill9 = InitializeButton("DionysusSkill9", OnDionysusSkill9Click);

        _artemisSkill1 = InitializeButton("ArtemisSkill1", OnArtemisSkill1Click);
        _artemisSkill2 = InitializeButton("ArtemisSkill2", OnArtemisSkill2Click);
        _artemisSkill3 = InitializeButton("ArtemisSkill3", OnArtemisSkill3Click);
        _artemisSkill4 = InitializeButton("ArtemisSkill4", OnArtemisSkill4Click);
        _artemisSkill5 = InitializeButton("ArtemisSkill5", OnArtemisSkill5Click);
        _artemisSkill6 = InitializeButton("ArtemisSkill6", OnArtemisSkill6Click);
        _artemisSkill7 = InitializeButton("ArtemisSkill7", OnArtemisSkill7Click);
        _artemisSkill8 = InitializeButton("ArtemisSkill8", OnArtemisSkill8Click);
        _artemisSkill9 = InitializeButton("ArtemisSkill9", OnArtemisSkill9Click);

        _athenaSkill1 = InitializeButton("AthenaSkill1", OnAthenaSkill1Click);
        _athenaSkill2 = InitializeButton("AthenaSkill2", OnAthenaSkill2Click);
        _athenaSkill3 = InitializeButton("AthenaSkill3", OnAthenaSkill3Click);
        _athenaSkill4 = InitializeButton("AthenaSkill4", OnAthenaSkill4Click);
        _athenaSkill5 = InitializeButton("AthenaSkill5", OnAthenaSkill5Click);
        _athenaSkill6 = InitializeButton("AthenaSkill6", OnAthenaSkill6Click);
        _athenaSkill7 = InitializeButton("AthenaSkill7", OnAthenaSkill7Click);
        _athenaSkill8 = InitializeButton("AthenaSkill8", OnAthenaSkill8Click);
        _athenaSkill9 = InitializeButton("AthenaSkill9", OnAthenaSkill9Click);

        _nemesisSkill1 = InitializeButton("NemesisSkill1", OnNemesisSkill1Click);
        _nemesisSkill2 = InitializeButton("NemesisSkill2", OnNemesisSkill2Click);
        _nemesisSkill3 = InitializeButton("NemesisSkill3", OnNemesisSkill3Click);
        _nemesisSkill4 = InitializeButton("NemesisSkill4", OnNemesisSkill4Click);
        _nemesisSkill5 = InitializeButton("NemesisSkill5", OnNemesisSkill5Click);
        _nemesisSkill6 = InitializeButton("NemesisSkill6", OnNemesisSkill6Click);
        _nemesisSkill7 = InitializeButton("NemesisSkill7", OnNemesisSkill7Click);
        _nemesisSkill8 = InitializeButton("NemesisSkill8", OnNemesisSkill8Click);
        _nemesisSkill9 = InitializeButton("NemesisSkill9", OnNemesisSkill9Click);

        _nyxSkill1 = InitializeButton("NyxSkill1", OnNyxSkill1Click);
        _nyxSkill2 = InitializeButton("NyxSkill2", OnNyxSkill2Click);
        _nyxSkill3 = InitializeButton("NyxSkill3", OnNyxSkill3Click);
        _nyxSkill4 = InitializeButton("NyxSkill4", OnNyxSkill4Click);
        _nyxSkill5 = InitializeButton("NyxSkill5", OnNyxSkill5Click);
        _nyxSkill6 = InitializeButton("NyxSkill6", OnNyxSkill6Click);
        _nyxSkill7 = InitializeButton("NyxSkill7", OnNyxSkill7Click);
        _nyxSkill8 = InitializeButton("NyxSkill8", OnNyxSkill8Click);
        _nyxSkill9 = InitializeButton("NyxSkill9", OnNyxSkill9Click);
        


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

        if (_apolloSkill1 != null) _apolloSkill1.RegisterCallback<ClickEvent>(OnApolloSkill1Click);
        if (_apolloSkill2 != null) _apolloSkill2.RegisterCallback<ClickEvent>(OnApolloSkill2Click);
        if (_apolloSkill3 != null) _apolloSkill3.RegisterCallback<ClickEvent>(OnApolloSkill3Click);
        if (_apolloSkill4 != null) _apolloSkill4.RegisterCallback<ClickEvent>(OnApolloSkill4Click);
        if (_apolloSkill5 != null) _apolloSkill5.RegisterCallback<ClickEvent>(OnApolloSkill5Click);
        if (_apolloSkill6 != null) _apolloSkill6.RegisterCallback<ClickEvent>(OnApolloSkill6Click);
        if (_apolloSkill7 != null) _apolloSkill7.RegisterCallback<ClickEvent>(OnApolloSkill7Click);
        if (_apolloSkill8 != null) _apolloSkill8.RegisterCallback<ClickEvent>(OnApolloSkill8Click);
        if (_apolloSkill9 != null) _apolloSkill9.RegisterCallback<ClickEvent>(OnApolloSkill9Click);

        if (_dionysusSkill1 != null) _dionysusSkill1.RegisterCallback<ClickEvent>(OnDionysusSkill1Click);
        if (_dionysusSkill2 != null) _dionysusSkill2.RegisterCallback<ClickEvent>(OnDionysusSkill2Click);
        if (_dionysusSkill3 != null) _dionysusSkill3.RegisterCallback<ClickEvent>(OnDionysusSkill3Click);
        if (_dionysusSkill4 != null) _dionysusSkill4.RegisterCallback<ClickEvent>(OnDionysusSkill4Click);
        if (_dionysusSkill5 != null) _dionysusSkill5.RegisterCallback<ClickEvent>(OnDionysusSkill5Click);
        if (_dionysusSkill6 != null) _dionysusSkill6.RegisterCallback<ClickEvent>(OnDionysusSkill6Click);
        if (_dionysusSkill7 != null) _dionysusSkill7.RegisterCallback<ClickEvent>(OnDionysusSkill7Click);
        if (_dionysusSkill8 != null) _dionysusSkill8.RegisterCallback<ClickEvent>(OnDionysusSkill8Click);
        if (_dionysusSkill9 != null) _dionysusSkill9.RegisterCallback<ClickEvent>(OnDionysusSkill9Click);

        if (_artemisSkill1 != null) _artemisSkill1.RegisterCallback<ClickEvent>(OnArtemisSkill1Click);
        if (_artemisSkill2 != null) _artemisSkill2.RegisterCallback<ClickEvent>(OnArtemisSkill2Click);
        if (_artemisSkill3 != null) _artemisSkill3.RegisterCallback<ClickEvent>(OnArtemisSkill3Click);
        if (_artemisSkill4 != null) _artemisSkill4.RegisterCallback<ClickEvent>(OnArtemisSkill4Click);
        if (_artemisSkill5 != null) _artemisSkill5.RegisterCallback<ClickEvent>(OnArtemisSkill5Click);
        if (_artemisSkill6 != null) _artemisSkill6.RegisterCallback<ClickEvent>(OnArtemisSkill6Click);
        if (_artemisSkill7 != null) _artemisSkill7.RegisterCallback<ClickEvent>(OnArtemisSkill7Click);
        if (_artemisSkill8 != null) _artemisSkill8.RegisterCallback<ClickEvent>(OnArtemisSkill8Click);
        if (_artemisSkill9 != null) _artemisSkill9.RegisterCallback<ClickEvent>(OnArtemisSkill9Click);

        if (_athenaSkill1 != null) _athenaSkill1.RegisterCallback<ClickEvent>(OnAthenaSkill1Click);
        if (_athenaSkill2 != null) _athenaSkill2.RegisterCallback<ClickEvent>(OnAthenaSkill2Click);
        if (_athenaSkill3 != null) _athenaSkill3.RegisterCallback<ClickEvent>(OnAthenaSkill3Click);
        if (_athenaSkill4 != null) _athenaSkill4.RegisterCallback<ClickEvent>(OnAthenaSkill4Click);
        if (_athenaSkill5 != null) _athenaSkill5.RegisterCallback<ClickEvent>(OnAthenaSkill5Click);
        if (_athenaSkill6 != null) _athenaSkill6.RegisterCallback<ClickEvent>(OnAthenaSkill6Click);
        if (_athenaSkill7 != null) _athenaSkill7.RegisterCallback<ClickEvent>(OnAthenaSkill7Click);
        if (_athenaSkill8 != null) _athenaSkill8.RegisterCallback<ClickEvent>(OnAthenaSkill8Click);
        if (_athenaSkill9 != null) _athenaSkill9.RegisterCallback<ClickEvent>(OnAthenaSkill9Click);

        if (_nemesisSkill1 != null) _nemesisSkill1.RegisterCallback<ClickEvent>(OnNemesisSkill1Click);
        if (_nemesisSkill2 != null) _nemesisSkill2.RegisterCallback<ClickEvent>(OnNemesisSkill2Click);
        if (_nemesisSkill3 != null) _nemesisSkill3.RegisterCallback<ClickEvent>(OnNemesisSkill3Click);
        if (_nemesisSkill4 != null) _nemesisSkill4.RegisterCallback<ClickEvent>(OnNemesisSkill4Click);
        if (_nemesisSkill5 != null) _nemesisSkill5.RegisterCallback<ClickEvent>(OnNemesisSkill5Click);
        if (_nemesisSkill6 != null) _nemesisSkill6.RegisterCallback<ClickEvent>(OnNemesisSkill6Click);
        if (_nemesisSkill7 != null) _nemesisSkill7.RegisterCallback<ClickEvent>(OnNemesisSkill7Click);
        if (_nemesisSkill8 != null) _nemesisSkill8.RegisterCallback<ClickEvent>(OnNemesisSkill8Click);
        if (_nemesisSkill9 != null) _nemesisSkill9.RegisterCallback<ClickEvent>(OnNemesisSkill9Click);

        if (_nyxSkill1 != null) _nyxSkill1.RegisterCallback<ClickEvent>(OnNyxSkill1Click);
        if (_nyxSkill2 != null) _nyxSkill2.RegisterCallback<ClickEvent>(OnNyxSkill2Click);
        if (_nyxSkill3 != null) _nyxSkill3.RegisterCallback<ClickEvent>(OnNyxSkill3Click);
        if (_nyxSkill4 != null) _nyxSkill4.RegisterCallback<ClickEvent>(OnNyxSkill4Click);
        if (_nyxSkill5 != null) _nyxSkill5.RegisterCallback<ClickEvent>(OnNyxSkill5Click);
        if (_nyxSkill6 != null) _nyxSkill6.RegisterCallback<ClickEvent>(OnNyxSkill6Click);
        if (_nyxSkill7 != null) _nyxSkill7.RegisterCallback<ClickEvent>(OnNyxSkill7Click);
        if (_nyxSkill8 != null) _nyxSkill8.RegisterCallback<ClickEvent>(OnNyxSkill8Click);
        if (_nyxSkill9 != null) _nyxSkill9.RegisterCallback<ClickEvent>(OnNyxSkill9Click);

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

        UnregisterAresSkillButton(_aresSkill1, OnAresSkill1Click);
        UnregisterAresSkillButton(_aresSkill2, OnAresSkill2Click);
        UnregisterAresSkillButton(_aresSkill3, OnAresSkill3Click);
        UnregisterAresSkillButton(_aresSkill4, OnAresSkill4Click);
        UnregisterAresSkillButton(_aresSkill5, OnAresSkill5Click);
        UnregisterAresSkillButton(_aresSkill6, OnAresSkill6Click);
        UnregisterAresSkillButton(_aresSkill7, OnAresSkill7Click);
        UnregisterAresSkillButton(_aresSkill8, OnAresSkill8Click);
        UnregisterAresSkillButton(_aresSkill9, OnAresSkill9Click);

        // Unregister apollo skill buttons

        UnregisterApolloSkillButton(_apolloSkill1, OnApolloSkill1Click);
        UnregisterApolloSkillButton(_apolloSkill2, OnApolloSkill2Click);
        UnregisterApolloSkillButton(_apolloSkill3, OnApolloSkill3Click);
        UnregisterApolloSkillButton(_apolloSkill4, OnApolloSkill4Click);
        UnregisterApolloSkillButton(_apolloSkill5, OnApolloSkill5Click);
        UnregisterApolloSkillButton(_apolloSkill6, OnApolloSkill6Click);
        UnregisterApolloSkillButton(_apolloSkill7, OnApolloSkill7Click);
        UnregisterApolloSkillButton(_apolloSkill8, OnApolloSkill8Click);
        UnregisterApolloSkillButton(_apolloSkill9, OnApolloSkill9Click);

        // Unregister dionysus skill buttons

        UnregisterDionysusSkillButton(_dionysusSkill1, OnDionysusSkill1Click);
        UnregisterDionysusSkillButton(_dionysusSkill2, OnDionysusSkill2Click);
        UnregisterDionysusSkillButton(_dionysusSkill3, OnDionysusSkill3Click);
        UnregisterDionysusSkillButton(_dionysusSkill4, OnDionysusSkill4Click);
        UnregisterDionysusSkillButton(_dionysusSkill5, OnDionysusSkill5Click);
        UnregisterDionysusSkillButton(_dionysusSkill6, OnDionysusSkill6Click);
        UnregisterDionysusSkillButton(_dionysusSkill7, OnDionysusSkill7Click);
        UnregisterDionysusSkillButton(_dionysusSkill8, OnDionysusSkill8Click);
        UnregisterDionysusSkillButton(_dionysusSkill9, OnDionysusSkill9Click);

        // Unregister Artemis skill buttons

        UnregisterArtemisSkillButton(_artemisSkill1, OnArtemisSkill1Click);
        UnregisterArtemisSkillButton(_artemisSkill2, OnArtemisSkill2Click);
        UnregisterArtemisSkillButton(_artemisSkill3, OnArtemisSkill3Click);
        UnregisterArtemisSkillButton(_artemisSkill4, OnArtemisSkill4Click);
        UnregisterArtemisSkillButton(_artemisSkill5, OnArtemisSkill5Click);
        UnregisterArtemisSkillButton(_artemisSkill6, OnArtemisSkill6Click);
        UnregisterArtemisSkillButton(_artemisSkill7, OnArtemisSkill7Click);
        UnregisterArtemisSkillButton(_artemisSkill8, OnArtemisSkill8Click);
        UnregisterArtemisSkillButton(_artemisSkill9, OnArtemisSkill9Click);

        // Unregister Athena skill buttons

        UnregisterAthenaSkillButton(_athenaSkill1, OnAthenaSkill1Click);
        UnregisterAthenaSkillButton(_athenaSkill2, OnAthenaSkill2Click);
        UnregisterAthenaSkillButton(_athenaSkill3, OnAthenaSkill3Click);
        UnregisterAthenaSkillButton(_athenaSkill4, OnAthenaSkill4Click);
        UnregisterAthenaSkillButton(_athenaSkill5, OnAthenaSkill5Click);
        UnregisterAthenaSkillButton(_athenaSkill6, OnAthenaSkill6Click);
        UnregisterAthenaSkillButton(_athenaSkill7, OnAthenaSkill7Click);
        UnregisterAthenaSkillButton(_athenaSkill8, OnAthenaSkill8Click);
        UnregisterAthenaSkillButton(_athenaSkill9, OnAthenaSkill9Click);

        // Unregister Nemesis skill buttons

        UnregisterNemesisSkillButton(_nemesisSkill1, OnNemesisSkill1Click);
        UnregisterNemesisSkillButton(_nemesisSkill2, OnNemesisSkill2Click);
        UnregisterNemesisSkillButton(_nemesisSkill3, OnNemesisSkill3Click);
        UnregisterNemesisSkillButton(_nemesisSkill4, OnNemesisSkill4Click);
        UnregisterNemesisSkillButton(_nemesisSkill5, OnNemesisSkill5Click);
        UnregisterNemesisSkillButton(_nemesisSkill6, OnNemesisSkill6Click);
        UnregisterNemesisSkillButton(_nemesisSkill7, OnNemesisSkill7Click);
        UnregisterNemesisSkillButton(_nemesisSkill8, OnNemesisSkill8Click);
        UnregisterNemesisSkillButton(_nemesisSkill9, OnNemesisSkill9Click);

        // Unregister Nyx skill buttons

        UnregisterNyxSkillButton(_nyxSkill1, OnNyxSkill1Click);
        UnregisterNyxSkillButton(_nyxSkill2, OnNyxSkill2Click);
        UnregisterNyxSkillButton(_nyxSkill3, OnNyxSkill3Click);
        UnregisterNyxSkillButton(_nyxSkill4, OnNyxSkill4Click);
        UnregisterNyxSkillButton(_nyxSkill5, OnNyxSkill5Click);
        UnregisterNyxSkillButton(_nyxSkill6, OnNyxSkill6Click);
        UnregisterNyxSkillButton(_nyxSkill7, OnNyxSkill7Click);
        UnregisterNyxSkillButton(_nyxSkill8, OnNyxSkill8Click);
        UnregisterNyxSkillButton(_nyxSkill9, OnNyxSkill9Click);


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

    private void UnregisterAresSkillButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }    
    
    private void UnregisterApolloSkillButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }
        private void UnregisterDionysusSkillButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }
    private void UnregisterArtemisSkillButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }
    private void UnregisterAthenaSkillButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }

    private void UnregisterNemesisSkillButton(Button button, EventCallback<ClickEvent> callback)
    {
        if (button != null)
        {
            button.UnregisterCallback<ClickEvent>(callback);
        }
    }
    private void UnregisterNyxSkillButton(Button button, EventCallback<ClickEvent> callback)
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
            CloseCurrentApolloSkillPanel();
            CloseCurrentDionysusSkillPanel();
            CloseCurrentArtemisSkillPanel();
            CloseCurrentAthenaSkillPanel();
            CloseCurrentNemesisSkillPanel();
            CloseCurrentNyxSkillPanel();
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
            CloseCurrentAresSkillPanel();
            CloseCurrentDionysusSkillPanel();
            CloseCurrentArtemisSkillPanel();
            CloseCurrentAthenaSkillPanel();
            CloseCurrentNemesisSkillPanel();
            CloseCurrentNyxSkillPanel();
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
            CloseCurrentAresSkillPanel();
            CloseCurrentApolloSkillPanel();
            CloseCurrentArtemisSkillPanel();
            CloseCurrentAthenaSkillPanel();
            CloseCurrentNemesisSkillPanel();
            CloseCurrentNyxSkillPanel();
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
            CloseCurrentAresSkillPanel();
            CloseCurrentApolloSkillPanel();
            CloseCurrentDionysusSkillPanel();
            CloseCurrentAthenaSkillPanel();
            CloseCurrentNemesisSkillPanel();
            CloseCurrentNyxSkillPanel();
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
            CloseCurrentAresSkillPanel();
            CloseCurrentApolloSkillPanel();
            CloseCurrentDionysusSkillPanel();
            CloseCurrentArtemisSkillPanel();
            CloseCurrentNemesisSkillPanel();
            CloseCurrentNyxSkillPanel();
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
            CloseCurrentAresSkillPanel();
            CloseCurrentApolloSkillPanel();
            CloseCurrentArtemisSkillPanel();
            CloseCurrentDionysusSkillPanel();
            CloseCurrentAthenaSkillPanel();
            CloseCurrentNyxSkillPanel();
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
            CloseCurrentAresSkillPanel();
            CloseCurrentApolloSkillPanel();
            CloseCurrentDionysusSkillPanel();
            CloseCurrentArtemisSkillPanel();
            CloseCurrentAthenaSkillPanel();
            CloseCurrentNemesisSkillPanel();
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

    private void CloseCurrentAresSkillPanel()
    {
        if (_currentAresSkillPanel != null)
        {
            _currentAresSkillPanel.RemoveFromClassList("moveAresSkillPopUpPanelIntoFrame");
            _currentAresSkillPanel = null;
        }
    }

    private void CloseCurrentApolloSkillPanel()
    {
        if (_currentApolloSkillPanel != null)
        {
            _currentApolloSkillPanel.RemoveFromClassList("moveApolloSkillPopUpPanelIntoFrame");
            _currentApolloSkillPanel = null;
        }
    }

    private void CloseCurrentDionysusSkillPanel()
    {
        if (_currentDionysusSkillPanel != null)
        {
            _currentDionysusSkillPanel.RemoveFromClassList("moveDionysusSkillPopUpPanelIntoFrame");
            _currentDionysusSkillPanel = null;
        }
    }

    private void CloseCurrentArtemisSkillPanel()
    {
        if (_currentArtemisSkillPanel != null)
        {
            _currentArtemisSkillPanel.RemoveFromClassList("moveArtemisSkillPopUpPanelIntoFrame");
            _currentArtemisSkillPanel = null;
        }
    }
    private void CloseCurrentAthenaSkillPanel()
    {
        if (_currentAthenaSkillPanel != null)
        {
            _currentAthenaSkillPanel.RemoveFromClassList("moveAthenaSkillPopUpPanelIntoFrame");
            _currentAthenaSkillPanel = null;
        }
    }

    private void CloseCurrentNemesisSkillPanel()
    {
        if (_currentNemesisSkillPanel != null)
        {
            _currentNemesisSkillPanel.RemoveFromClassList("moveNemesisSkillPopUpPanelIntoFrame");
            _currentNemesisSkillPanel = null;
        }
    }

    private void CloseCurrentNyxSkillPanel()
    {
        if (_currentNyxSkillPanel != null)
        {
            _currentNyxSkillPanel.RemoveFromClassList("moveNyxSkillPopUpPanelIntoFrame");
            _currentNyxSkillPanel = null;
        }
    }



    private void OnAresSkill1Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 1 Button");
        CloseCurrentAresSkillPanel();
        _aresSkillPopUp1.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp1;
    }

    private void OnAresSkill2Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 2 Button");
        CloseCurrentAresSkillPanel();
        _aresSkillPopUp2.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp2;
    }

    private void OnAresSkill3Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 3 Button");
        CloseCurrentAresSkillPanel();
        _aresSkillPopUp3.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp3;

    }
    private void OnAresSkill4Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 4 Button");
        CloseCurrentAresSkillPanel();
        _aresSkillPopUp4.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp4;

    }

    private void OnAresSkill5Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 5 Button");
        CloseCurrentAresSkillPanel(); 
        _aresSkillPopUp5.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp5;

    }
    private void OnAresSkill6Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 6 Button");
        CloseCurrentAresSkillPanel();
        _aresSkillPopUp6.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp6;

    }
    private void OnAresSkill7Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 7 Button");
        CloseCurrentAresSkillPanel();
        _aresSkillPopUp7.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp7;
    }

    private void OnAresSkill8Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 8 Button");
        CloseCurrentAresSkillPanel();
        _aresSkillPopUp8.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp8;

    }
    private void OnAresSkill9Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Ares Skill 9 Button");
        CloseCurrentAresSkillPanel();
        _aresSkillPopUp9.AddToClassList("moveAresSkillPopUpPanelIntoFrame");
        _currentAresSkillPanel = _aresSkillPopUp9;
    }

    private void OnApolloSkill1Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 1 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp1.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp1;
    }
    private void OnApolloSkill2Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 2 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp2.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp2;
    }
    private void OnApolloSkill3Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 3 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp3.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp3;
    }
    private void OnApolloSkill4Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 4 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp4.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp4;
    }
    private void OnApolloSkill5Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 5 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp5.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp5;
    }
    private void OnApolloSkill6Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 6 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp6.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp6;
    }
    private void OnApolloSkill7Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 7 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp7.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp7;
    }
    private void OnApolloSkill8Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 8 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp8.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp8;
    }
    private void OnApolloSkill9Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Apollo Skill 9 Button");
        CloseCurrentApolloSkillPanel();
        _apolloSkillPopUp9.AddToClassList("moveApolloSkillPopUpPanelIntoFrame");
        _currentApolloSkillPanel = _apolloSkillPopUp9;
    }

    private void OnDionysusSkill1Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 1 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp1.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp1;
    }

    private void OnDionysusSkill2Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 2 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp2.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp2;
    }
    private void OnDionysusSkill3Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 3 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp3.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp3;
    }
    private void OnDionysusSkill4Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 4 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp4.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp4;
    }
    private void OnDionysusSkill5Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 5 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp5.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp5;
    }
    private void OnDionysusSkill6Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 6 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp6.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp6;
    }
    private void OnDionysusSkill7Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 7 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp7.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp7;
    }
    private void OnDionysusSkill8Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 8 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp8.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp8;
    }
    private void OnDionysusSkill9Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Dionysus Skill 9 Button");
        CloseCurrentDionysusSkillPanel();
        _dionysusSkillPopUp9.AddToClassList("moveDionysusSkillPopUpPanelIntoFrame");
        _currentDionysusSkillPanel = _dionysusSkillPopUp9;
    }

    private void OnArtemisSkill1Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 1 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp1.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp1;
    }
    private void OnArtemisSkill2Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 2 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp2.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp2;
    }
    private void OnArtemisSkill3Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 3 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp3.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp3;
    }
    private void OnArtemisSkill4Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 4 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp4.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp4;
    }
    private void OnArtemisSkill5Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 5 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp5.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp5;
    }
    private void OnArtemisSkill6Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 6 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp6.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp6;
    }
    private void OnArtemisSkill7Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 7 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp7.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp7;
    }
    private void OnArtemisSkill8Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 8 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp8.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp8;
    }
    private void OnArtemisSkill9Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Artemis Skill 9 Button");
        CloseCurrentArtemisSkillPanel();
        _artemisSkillPopUp9.AddToClassList("moveArtemisSkillPopUpPanelIntoFrame");
        _currentArtemisSkillPanel = _artemisSkillPopUp9;
    }

    private void OnAthenaSkill1Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 1 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp1.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp1;
    }
    private void OnAthenaSkill2Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 2 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp2.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp2;
    }
    private void OnAthenaSkill3Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 3 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp3.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp3;
    }
    private void OnAthenaSkill4Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 1 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp4.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp4;
    }
    private void OnAthenaSkill5Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 5 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp5.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp5;
    }
    private void OnAthenaSkill6Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 6 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp6.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp6;
    }
    private void OnAthenaSkill7Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 7 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp7.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp7;
    }
    private void OnAthenaSkill8Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 6 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp8.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp8;
    }
    private void OnAthenaSkill9Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Athena Skill 9 Button");
        CloseCurrentAthenaSkillPanel();
        _athenaSkillPopUp9.AddToClassList("moveAthenaSkillPopUpPanelIntoFrame");
        _currentAthenaSkillPanel = _athenaSkillPopUp9;
    }

    private void OnNemesisSkill1Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 1 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp1.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp1;
    }
    private void OnNemesisSkill2Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 2 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp2.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp2;
    }
    private void OnNemesisSkill3Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 3 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp3.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp3;
    }
    private void OnNemesisSkill4Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 1 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp4.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp4;
    }
    private void OnNemesisSkill5Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 5 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp5.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp5;
    }
    private void OnNemesisSkill6Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 6 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp6.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp6;
    }
    private void OnNemesisSkill7Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 7 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp7.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp7;
    }
    private void OnNemesisSkill8Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 8 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp8.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp8;
    }

    private void OnNemesisSkill9Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nemesis Skill 9 Button");
        CloseCurrentNemesisSkillPanel();
        _nemesisSkillPopUp9.AddToClassList("moveNemesisSkillPopUpPanelIntoFrame");
        _currentNemesisSkillPanel = _nemesisSkillPopUp9;
    }
    private void OnNyxSkill1Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 1 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp1.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp1;
    }
    private void OnNyxSkill2Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 2 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp2.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp2;
    }
    private void OnNyxSkill3Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 3 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp3.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp3;
    }
    private void OnNyxSkill4Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 4 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp4.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp4;
    }
    private void OnNyxSkill5Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 5 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp5.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp5;
    }
    private void OnNyxSkill6Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 3 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp6.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp6;
    }
    private void OnNyxSkill7Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 3 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp7.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp7;
    }
    private void OnNyxSkill8Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 8 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp8.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp8;
    }
    private void OnNyxSkill9Click(ClickEvent evt)
    {
        Debug.Log("You pressed the Nyx Skill 3 Button");
        CloseCurrentNyxSkillPanel();
        _nyxSkillPopUp9.AddToClassList("moveNyxSkillPopUpPanelIntoFrame");
        _currentNyxSkillPanel = _nyxSkillPopUp9;
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
