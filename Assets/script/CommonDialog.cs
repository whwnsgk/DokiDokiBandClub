using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CommonDialog : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    [SerializeField] private GameObject SceneDir;

    private bool isDialogue = false;
    private bool isCanClick = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    void Start()
    {
        isCanClick = true;
        ShowDialogue();
    }

    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space) && isCanClick)
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                {
                    SceneDir.GetComponent<SceneDirector>().NextScene();
                }
            }

        }
    }

    public void ShowDialogue()
    {
        sprite_DialogueBox.gameObject.SetActive(true);
        sprite_StandingCG.gameObject.SetActive(true);
        txt_Dialogue.gameObject.SetActive(true);

        count = 0;
        isDialogue = true;

        NextDialogue();
    }

    private void HideDialogue()
    {
        sprite_DialogueBox.gameObject.SetActive(false);
        sprite_StandingCG.gameObject.SetActive(false);
        txt_Dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }

    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        sprite_StandingCG.sprite = dialogue[count].cg;
        count++;
    }

    public void SetCanClick(bool inCanClick)
    {
        isCanClick = inCanClick;
    }
}
