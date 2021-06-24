using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GridController : MonoBehaviour
{

    public Button myPrefabs;
    public GameObject Grid;
    [SerializeField] Sprite[] Letters;
    [SerializeField] Sprite[] Numbers;
    [SerializeField] Text Finder;
    public string Answer;
    public int level = 0;
    public List<Button> slots = new List<Button>();
    public string[] repeatedAnswers = { null,null };

    void Start()
    {
        //Level 1 call
        easyLevel();

         
    }

    // Update is called once per frame
    void Update()
    {

    }


    //Easy Level which includes 3 variants of Answer, 1 correct and 2 incorrect
    public void easyLevel()
    {
        //letters = 0, numbers=1
        int rand = Random.Range(0, 2);
        int[] arr = { -1, -1, -1 };




        for (int i = 0; i <= 2; i++)
        {
            if (rand == 0)
            {
                int randLetters = Random.Range(0, 26);

                while (randLetters == arr[0] || randLetters == arr[1] || randLetters == arr[2])
                {
                    randLetters = Random.Range(0, 26);
                }

                arr[i] = randLetters;
                Button Letter = Instantiate(myPrefabs, Grid.transform) as Button;
                Letter.GetComponent<Image>().sprite = Letters[randLetters]; 
                Letter.transform.DORewind();
                Letter.transform.DOPunchScale(new Vector3(1, 1, 1), 1f,10,.4f).SetUpdate(true);
                slots.Add(Letter);
            }
            else
            {

                int randNumbers = Random.Range(0, 9);
                while (randNumbers == arr[0] || randNumbers == arr[1] || randNumbers == arr[2])
                {
                    randNumbers = Random.Range(0, 9);
                }
                arr[i] = randNumbers;
                Button Number = Instantiate(myPrefabs, Grid.transform) as Button;
                Number.GetComponent<Image>().sprite = Numbers[randNumbers];
                Number.transform.DORewind();
                Number.transform.DOPunchScale(new Vector3(1, 1, 1), 1f, 10, .4f).SetUpdate(true);
                slots.Add(Number);
            }

        }
        if (rand == 0)
        {
            int randAnswer = Random.Range(0, 3);
            Finder.text = "Find: " + Letters[arr[randAnswer]].name;
            Finder.color = new Color(Finder.color.r, Finder.color.g, Finder.color.b, 0);
            Finder.GetComponent<TextTransform>().FadeIn();
            Answer = Letters[arr[randAnswer]].name;
        }
        else
        {
            int randAnswer = Random.Range(0, 3);
            Finder.text = "Find: " + Numbers[arr[randAnswer]].name;
            Finder.color = new Color(Finder.color.r, Finder.color.g, Finder.color.b, 0);
            Finder.GetComponent<TextTransform>().FadeIn();
            Answer = Numbers[arr[randAnswer]].name;
        }
        repeatedAnswers[0] = Answer;
    }

    //Medium Level which includes 6 variants of Answer, 1 correct and 4 incorrect
    public void mediumLevel()
    {
        
        int rand = Random.Range(0, 2);
        int[] arr = { -1, -1, -1,-1,-1,-1 };

        if (rand == 0)
        {
            for(int i =0;i<3;i++)
            {
                int randLetters = Random.Range(0, 26);

                while (randLetters == arr[0] || randLetters == arr[1] || randLetters == arr[2])
                {
                    randLetters = Random.Range(0, 26);
                }

                arr[i] = randLetters;
                slots[i].GetComponent<Image>().sprite = Letters[randLetters];
            }
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                int randNumbers = Random.Range(0, 9);

                while (randNumbers == arr[0] || randNumbers == arr[1] || randNumbers == arr[2])
                {
                    randNumbers = Random.Range(0, 9);
                }

                arr[i] = randNumbers;
                slots[i].GetComponent<Image>().sprite = Numbers[randNumbers];
            }
        }


            for (int i = 3; i <= 5; i++)
        {
            if (rand == 0)
            {
                int randLetters = Random.Range(0, 26);

                while (randLetters == arr[0] || randLetters == arr[1] || randLetters == arr[2] || randLetters == arr[3] || randLetters == arr[4] || randLetters == arr[5])
                {
                    randLetters = Random.Range(0, 26);
                }

                arr[i] = randLetters;
                Button Letter = Instantiate(myPrefabs, Grid.transform) as Button;
                Letter.GetComponent<Image>().sprite = Letters[randLetters];
                slots.Add(Letter);
            }
            else
            {

                int randNumbers = Random.Range(0, 9);
                while (randNumbers == arr[0] || randNumbers == arr[1] || randNumbers == arr[2]|| randNumbers == arr[3] || randNumbers == arr[4] || randNumbers == arr[5])
                {
                    randNumbers = Random.Range(0, 9);
                }
                arr[i] = randNumbers;
                Button Number = Instantiate(myPrefabs, Grid.transform) as Button;
                Number.GetComponent<Image>().sprite = Numbers[randNumbers];
                slots.Add(Number);
            }

        }
        if (rand == 0)
        {
            int randAnswer = Random.Range(0, 6);
            string temp = Letters[arr[randAnswer]].name;
            while(repeatedAnswers[0]==temp) 
            {
                randAnswer = Random.Range(0, 6);
                temp = Letters[arr[randAnswer]].name;
            }
            Finder.text = "Find: " + Letters[arr[randAnswer]].name;
            Finder.color = new Color(Finder.color.r, Finder.color.g, Finder.color.b, 0);
            Finder.GetComponent<TextTransform>().FadeIn();
            Answer = Letters[arr[randAnswer]].name;
        }
        else
        {
            int randAnswer = Random.Range(0, 6);
            string temp = Letters[arr[randAnswer]].name;
            while (repeatedAnswers[0] == temp)
            {
                randAnswer = Random.Range(0, 6);
                temp = Letters[arr[randAnswer]].name;
            }
            Finder.text = "Find: " + Numbers[arr[randAnswer]].name;
            Finder.color = new Color(Finder.color.r, Finder.color.g, Finder.color.b, 0);
            Finder.GetComponent<TextTransform>().FadeIn();
            Answer = Numbers[arr[randAnswer]].name;
        }
        repeatedAnswers[1] = Answer;
    }

    //Hard Level which includes 9 variants of Answer, 1 correct and 8 incorrect
    public void hardLevel() 
    {
        int rand = Random.Range(0, 2);
        int[] arr = { -1, -1, -1, -1, -1, -1, -1, -1, -1 };

        if (rand == 0)
        {
            for (int i = 0; i < 6; i++)
            {
                int randLetters = Random.Range(0, 26);

                while (randLetters == arr[0] || randLetters == arr[1] || randLetters == arr[2] || randLetters == arr[3] || randLetters == arr[4] || randLetters == arr[5])
                {
                    randLetters = Random.Range(0, 26);
                }

                arr[i] = randLetters;
                slots[i].GetComponent<Image>().sprite = Letters[randLetters];
            }
        }
        else
        {
            for (int i = 0; i < 6; i++)
            {
                int randNumbers = Random.Range(0, 9);

                while (randNumbers == arr[0] || randNumbers == arr[1] || randNumbers == arr[2] || randNumbers == arr[3] || randNumbers == arr[4] || randNumbers == arr[5])
                {
                    randNumbers = Random.Range(0, 9);
                }

                arr[i] = randNumbers;
                slots[i].GetComponent<Image>().sprite = Numbers[randNumbers];
            }
        }


        for (int i = 6; i <= 8; i++)
        {
            if (rand == 0)
            {
                int randLetters = Random.Range(0, 26);

                while (randLetters == arr[0] || randLetters == arr[1] || randLetters == arr[2] || randLetters == arr[3] || randLetters == arr[4] || randLetters == arr[5] || randLetters == arr[6] || randLetters == arr[7] || randLetters == arr[8])
                {
                    randLetters = Random.Range(0, 26);
                }

                arr[i] = randLetters;
                Button Letter = Instantiate(myPrefabs, Grid.transform) as Button;
                Letter.GetComponent<Image>().sprite = Letters[randLetters];
                slots.Add(Letter);
            }
            else
            {

                int randNumbers = Random.Range(0, 9);
                while (randNumbers == arr[0] || randNumbers == arr[1] || randNumbers == arr[2] || randNumbers == arr[3] || randNumbers == arr[4] || randNumbers == arr[5] || randNumbers == arr[6] || randNumbers == arr[7] || randNumbers == arr[8])
                {
                    randNumbers = Random.Range(0, 9);
                }
                arr[i] = randNumbers;
                Button Number = Instantiate(myPrefabs, Grid.transform) as Button;
                Number.GetComponent<Image>().sprite = Numbers[randNumbers];
                slots.Add(Number);
            }

        }
        if (rand == 0)
        {
            int randAnswer = Random.Range(0, 9);
            string temp = Letters[arr[randAnswer]].name;
            while (repeatedAnswers[0] == temp|| repeatedAnswers[1] == temp)
            {
                randAnswer = Random.Range(0, 6);
                temp = Letters[arr[randAnswer]].name;
            }
            Finder.text = "Find: " + Letters[arr[randAnswer]].name;
            Finder.color = new Color(Finder.color.r, Finder.color.g, Finder.color.b, 0);
            Finder.GetComponent<TextTransform>().FadeIn();
            Answer = Letters[arr[randAnswer]].name;
        }
        else
        {
            int randAnswer = Random.Range(0, 9);
            string temp = Letters[arr[randAnswer]].name;
            while (repeatedAnswers[0] == temp || repeatedAnswers[1] == temp)
            {
                randAnswer = Random.Range(0, 6);
                temp = Letters[arr[randAnswer]].name;
            }
            Finder.text = "Find: " + Numbers[arr[randAnswer]].name;
            Finder.color = new Color(Finder.color.r, Finder.color.g, Finder.color.b, 0);
            Finder.GetComponent<TextTransform>().FadeIn();
            Answer = Numbers[arr[randAnswer]].name;
        }
    }
}
