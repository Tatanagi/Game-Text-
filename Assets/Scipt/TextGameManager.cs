using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TextGameManager : MonoBehaviour
{

    // Start is called before the first frame update
    public int hp_Value, sanity_Value;
    public TextMeshProUGUI hptextvalue, sanityvalue, startofstory;
    public string Start_of_Story;
    void Start()
    {
        hp_Value = 100;
        sanity_Value = 100;
        Start_of_Story = " I just die and become human lol";

    }

    // Update is called once per frame
    void Update()
    {
        hptextvalue.text = hp_Value.ToString();
        sanityvalue.text = sanityvalue.ToString();
        startofstory.text = Start_of_Story;



    }
    public void home()
    {

    }
    public void die()
    {

    }
    public void idk()
    {

    }

}
