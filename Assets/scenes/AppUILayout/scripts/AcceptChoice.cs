using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AcceptChoice : MonoBehaviour {
    
    public string[] statementText;//= new string[] {"Statement1", "Statement2", "Statement3"};
    public bool overMouse;
    private PaddleController _paddleController;
    public Text StatementTextObject;
  //  List<int> statement = new List<int>();
    int currentStatement;
    int lastStatement;
    int snapPoint;
    int currentTextIndex = 0;
    bool canClickNext = true;
    //  int currentChar;
    paddle pad;  //  int character;

    //private var wave1 : List.<String> = new List.<String>();
    // private int waveArray = List.< List.< String > > = new List.< List.< String > > ();

    [SerializeField] List<int> statement = new List<int>();
    [SerializeField] List<int> character = new List<int>();
    [SerializeField] List<int> answers = new List<int>();
    //  List<List<int>> character = new List<List<int>>();
    //List<List<int>> statement = new List<List<int>>();
    //public float[] statement;
    //public float[] statementPoints;

    // Use this for initialization
    void Start()
    {
        _paddleController = FindObjectOfType<PaddleController>();
        int indexChar = character.IndexOf(120);

        pad = FindObjectOfType<paddle>();// List.IndexOf(character);


        statement.Add(1);
        statement.Add(2);
        statement.Add(3);
        statement.Add(4);
        statement.Add(5);
        statement.Add(6);
        statement.Add(7);
        statement.Add(8);
        statement.Add(9);
        statement.Add(10);
        statement.Add(11);
        statement.Add(12);
        statement.Add(13);
        statement.Add(14);
        statement.Add(15);
        statement.Add(16);
        statement.Add(17);
        statement.Add(18);
        statement.Add(19);
        statement.Add(20);

        foreach (int o in statement)
        {
            for (int i = 0; i< 6; i++)
            {
                character.Add(i);
            }
        }

        foreach (int p in character)
        {
            for (int i = 0; i< 4; i++)
            {
                answers.Add(i);
            }
        }
        currentStatement = 1;
        lastStatement = 1;
    }
	

   public void ClickingTask()
    {
        
        if (canClickNext)
        {
            lastStatement = currentStatement;
            currentStatement++;
            StatementTextObject.text = statementText[currentTextIndex];
            currentTextIndex++;
            Debug.Log(currentTextIndex);

            if (pad.buttonchoise == 1) {Debug.Log("give a charecter a point"); }
            if(pad.buttonchoise ==2){ }
            if (pad.buttonchoise == 3) { }
            if (pad.buttonchoise == 4) {Debug.Log("je hebt oneens geselecteerd"); }

        }

        if (currentTextIndex == 5 || currentTextIndex == 11 || currentTextIndex == 18)
        {
            canClickNext = false;
            StartCoroutine(Wait(5));
        }
    }

    public IEnumerator Wait(float waitTime)
    {
        this.gameObject.GetComponent<Image>().enabled = false;
        this.gameObject.GetComponentInChildren<Text>().enabled = false;
        yield return new WaitForSeconds(waitTime);
        canClickNext = true;
        this.gameObject.GetComponentInChildren<Text>().enabled = true;
        this.gameObject.GetComponent<Image>().enabled = true;
    }
}