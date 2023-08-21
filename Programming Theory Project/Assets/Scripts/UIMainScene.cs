using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMainScene : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text professionText;
    Character character;

    void Update()
    {
        character = FindAnyObjectByType<Character>().GetComponent<Character>();

        //POLYMORPHISM
        nameText.text = character.NameText();
        professionText.text = character.ProfessionText();
    }

    public void BackToMenu()
    {
        MainManager.Instance.DestroyCharacter();
        SceneManager.LoadScene(0);
    }
}
