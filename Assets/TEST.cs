using UnityEngine;
using UnityEngine.UI;

public class ButtonClickTest : MonoBehaviour
{
    private Button button;  // Reference to the button

    void Start()
    {
        // Find the button by its GameObject name or tag (use the correct name/tag for your scene)
        button = GameObject.Find("Button").GetComponent<Button>(); // Assuming the button's name is "Button"

        if (button != null)
        {
            // Add a listener to the button's OnClick() event
            button.onClick.AddListener(OnButtonClick);
        }
        else
        {
            Debug.LogError("Button not found!");
        }
    }

    // Method that gets called when the button is clicked
    void OnButtonClick()
    {
        Debug.Log("Button was clicked!");
    }
}
