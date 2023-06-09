using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public float displayDuration = 3f; // Adjust the duration as needed

    private float timer;

    private void Start()
    {
        timer = displayDuration;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            displayText.enabled = false;
        }
    }
}
