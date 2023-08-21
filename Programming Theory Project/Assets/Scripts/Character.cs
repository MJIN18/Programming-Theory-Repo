using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RotateCharacter();
    }

    public void RotateCharacter()
    {
        transform.Rotate(0, 1, 0);
    }

   public virtual void ChooseCharacter()
    {
        MainManager.Instance.SelectedCharacter = gameObject;

        CreateCharacter();

        SceneManager.LoadScene(1);
    }

    //ABSTRACTION
    private static void CreateCharacter()
    {
        int buildIndex = SceneManager.GetActiveScene().buildIndex;

        if(buildIndex == 0)
        {
            MainManager.Instance.SpawnCharacter();
        }
    }

    public virtual string NameText()
    {
        return "Name: ";
    }

    public virtual string ProfessionText()
    {
        return "Profession: ";
    }
}
