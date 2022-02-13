
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BadEnding : MonoBehaviour
{
    bool isAlive = true;


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
/*
    public void button1() // 정답
    {

        GameManager.LovePoint++;
        Debug.Log("엔딩 포인트: " + GameManager.LovePoint);

        SceneManager.LoadScene("Begin3");

    }
    public void button2() // 오답
    {
        SceneManager.LoadScene("Begin4");

    }
    */
    void Update()

    {


        if (isDialogue)
        {
            if (isAlive == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (count < dialogue.Length)

                        NextDialogue();
                    else
                        SceneManager.LoadScene("Title");
                }

            }
        }
        /*
        if (count == 4)

            GameObject.Find("Sprite Canvas").transform.Find("Image").gameObject.SetActive(true);

        else

            GameObject.Find("Sprite Canvas").transform.Find("Image").gameObject.SetActive(false);

     
        if (count == 28)
        {
            GameObject.Find("Sprite Canvas").transform.Find("Button1").gameObject.SetActive(true);
            GameObject.Find("Sprite Canvas").transform.Find("Button2").gameObject.SetActive(true);
            isAlive = false;


        }
        else
        {
            GameObject.Find("Sprite Canvas").transform.Find("Button1").gameObject.SetActive(false);
            GameObject.Find("Sprite Canvas").transform.Find("Button2").gameObject.SetActive(false);
        }

        */
    }
}
