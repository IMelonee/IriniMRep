using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
 * void OnAwake()
StartCoroutine (showWDialogue())

Ienumerator ShowWDialogue()
Textbox.text "Congratulations, you beat BOW. Game will now restart in 3....2.....1..."
turn Textbox on
yield return WaitForSeconds(Texttimer);
restart scene
*/
public class Win : MonoBehaviour
{

    //TEXTBOX
    public TMP_Text winText;
    public GameObject textBox;

    float textTimer = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        StartCoroutine(ShowWDialogue());

    }

    IEnumerator ShowWDialogue()
    {
        winText.text = "Congratulations, you beat RGB BOW. Game will now restart in 3....2.....1...";
        textBox.SetActive(true);

        yield return new WaitForSeconds(textTimer);

        SceneManager.LoadScene("MainLevel");

    }
}
