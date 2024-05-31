using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;

    public TextMeshProUGUI characterName;
    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }

        else
        {
            Load();
        }

        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.CharacterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
        Save();

    }

    public void BackOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = characterDB.CharacterCount - 1;
        }

        UpdateCharacter(selectedOption);
        Save();

    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        characterName.text = character.characterName;

    }


    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
