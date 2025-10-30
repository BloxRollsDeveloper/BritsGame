using UnityEngine;
using UnityEngine.UI;

public class ChoiceController : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Button;
    public GameObject Button2;
    public int Choice;

    public void Button1()
    {
        TextBox.GetComponent<Text>().text = "Simple Test.";
        Choice = 1;
    }

    public void Button2Method()
    {
        TextBox.GetComponent<Text>().text = "Simple Test 2.";
        Choice = 2;
    }

    void Update()
    {
        if (Choice >= 1)
        {
            Button.SetActive(false);
            Button2.SetActive(false);
        }
    }
}