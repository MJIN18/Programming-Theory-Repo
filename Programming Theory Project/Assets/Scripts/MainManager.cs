using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance { get; private set; }

    public GameObject selectedCharacter;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        HideDuplicateCharacter();
    }

    //ABSTRACTION
    private void HideDuplicateCharacter()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 1)
        {
            selectedCharacter.gameObject.SetActive(true);
        }
    }

    //ENCAPSULATION
    public GameObject SelectedCharacter
    {
        get
        {
            return selectedCharacter;
        }
        set
        {
            selectedCharacter = value;
        }
    }

    //ABSTRACTION
    public void SpawnCharacter()
    {
        Vector3 spawnPosition = new Vector3(-3.0f, 0, 0);
        selectedCharacter = Instantiate(selectedCharacter, spawnPosition, Quaternion.identity, transform);
        selectedCharacter.gameObject.SetActive(false);
    }

    public void DestroyCharacter()
    {
        Destroy(selectedCharacter);
    }
}
