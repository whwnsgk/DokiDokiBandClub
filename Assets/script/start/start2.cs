using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class start2 : MonoBehaviour
{
    public int EdPoint = 0;
    bool isAlive = true;
    

    [SerializeField] private SpriteRenderer sprite_StandingCG;
    [SerializeField] private SpriteRenderer sprite_DialogueBox;
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

    public void button1()
    {
        SceneManager.LoadScene("start3");

        
    }

    public void button2()
    {
        SceneManager.LoadScene("start4");
        EdPoint++;
        Debug.Log(EdPoint);
    }


    void Update()
    {


        if (isDialogue)
        {
            if(isAlive == true)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (count < dialogue.Length)
                        NextDialogue();
                    else
                        SceneManager.LoadScene("start2");

                }
               
            }
        }

        if (count == 4)
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

    }

 
}
