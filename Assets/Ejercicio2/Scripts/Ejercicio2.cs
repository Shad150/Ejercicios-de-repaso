using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio2 : MonoBehaviour
{
    
    int n = 4;
    float time = 10;
    int counter = 0;
    int Rcounter;
    bool isPause;

    public GameObject frasesGO;
    public Text frases;
    public Text timeT;

    //a)
    List<string> frasesMotivacionales = new List<string>() { "Javi's not dead (yet)", "Antivaxers gonna die after this", "Les pollution", "We have *vacations*, yay ", "We can continue the Roguelike" };        

    // Start is called before the first frame update
    void Start()
    {

        isPause = false;

        //b)
        for (int i = 0; i <= n; i++)                        
        {
            Debug.Log(frasesMotivacionales[i]);
        }

        frases.text = frasesMotivacionales[counter];

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeT.text = Mathf.Floor(time) + "";
        
        if (time < 0)
        {
            time = 10;
            counter ++ ;

            if (counter > 4)
            {
                counter = 0;
            }

            frases.text = frasesMotivacionales[counter];
            
        }

    }

    public void RandomButton()
    {
        if (isPause == false)
        {
            time = 10;

            Rcounter = Random.Range(0, 5);
            Debug.Log(Rcounter);

            frases.text = frasesMotivacionales[Rcounter];
        }
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

    }
}
