using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Begin3 : MonoBehaviour
{


    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private Image sprite_DialogueBox;
    [SerializeField] private Text txt_Dialogue;

    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    void Start()
    {

        ShowDialogue();

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

    void Update()

    {


        if (isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogue.Length)
                    NextDialogue();

                else
                    SceneManager.LoadScene("Begin5");



            }

        }
        /*
        if (count == 4)

            GameObject.Find("Sprite Canvas").transform.Find("Image").gameObject.SetActive(true);

        else

            GameObject.Find("Sprite Canvas").transform.Find("Image").gameObject.SetActive(false);

     */
    }
}
