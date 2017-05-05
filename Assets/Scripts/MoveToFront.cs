using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveToFront : MonoBehaviour {
    public GameObject[] sceneImages;
    public string levelName;
    private GameObject playScene;
    private GameObject gibMunny;

    void Start()
    {
        playScene = GameObject.Find("PlayScene");
        gibMunny = GameObject.Find("GibMunny");
        if (playScene != null)
        {
            playScene.SetActive(false);
        }
        if (gibMunny != null)
        {
            gibMunny.SetActive(false);
        }
    }

    public void ChangeTarget(string newTarget)
    {
        playScene.SetActive(true);
        levelName = newTarget;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(levelName);
    }
    public void ChangeImage(int number)
    {
        for (int i=0; i < sceneImages.Length; i++)
        {
            if (i == number)
            {
                sceneImages[i].SetActive(true);
            }
            else
            {
                sceneImages[i].SetActive(false);
            }

            if (number == 4 || number == 5 && gibMunny != null)
            {
                gibMunny.SetActive(true);
            }
            else if (gibMunny!=null)
            {
                gibMunny.SetActive(false);
            }
        }
    }
public void Front(GameObject button)
    {
        button.transform.SetAsLastSibling();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("HomelessUICheck");
    }
}
