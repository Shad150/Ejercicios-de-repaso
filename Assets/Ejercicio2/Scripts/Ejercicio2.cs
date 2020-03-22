using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio2 : MonoBehaviour
{
    
    int n = 4;
    float time = 10;

    public GameObject frasesGO;
    public Text frases;

    //a)
    List<string> frasesMotivacionales = new List<string>() { "Javi's not dead (yet)", "Antivaxers gonna die after this", "You survived NA classes, then you can survive this", "We have vacations, yay ", "We can continue the Roguelike" };        

    // Start is called before the first frame update
    void Start()
    {
        //b)
        for (int i = 0; i <= n; i++)                        
        {
            Debug.Log(frasesMotivacionales[i]);
        }

        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        frases.text = time.ToString();

        while (time < 10)
        {
            for (int i = 0; i < n; i++)
            {
                frases.text = frasesMotivacionales[i];
            }
            if (time > 10)
            {
                time = 0;
            }
        }
        

    }
}
