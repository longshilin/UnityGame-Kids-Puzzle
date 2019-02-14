using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private Transform[] Images;
    [SerializeField]
    private GameObject winText;
    public static bool youWin;

    public Animator gameFinishPanelAnim;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Images.Length == 6 &&
            Images[0].rotation.z == 0 &&
            Images[1].rotation.z == 0 &&
            Images[2].rotation.z == 0 &&
            Images[3].rotation.z == 0 &&
            Images[4].rotation.z == 0 &&
            Images[5].rotation.z == 0)
        {
            youWin = true;
            winText.SetActive(true);
            StartCoroutine(GameFinishPanel());
        }
        else if(Images.Length == 8 &&
            Images[0].rotation.z == 0 &&
            Images[1].rotation.z == 0 &&
            Images[2].rotation.z == 0 &&
            Images[3].rotation.z == 0 &&
            Images[4].rotation.z == 0 &&
            Images[5].rotation.z == 0 &&
            Images[6].rotation.z == 0 &&
            Images[7].rotation.z == 0)
        {
            youWin = true;
            winText.SetActive(true);
            StartCoroutine(GameFinishPanel());
        }
        
    }

    IEnumerator GameFinishPanel()
    {
        yield return new WaitForSeconds(1f);
        gameFinishPanelAnim.Play("SlideIn");
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
