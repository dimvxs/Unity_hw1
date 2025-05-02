using UnityEngine;

public class CounterScript : MonoBehaviour
{
    private TMPro.TextMeshProUGUI countText;
    private int counter;

    void Start()
    {
        counter = 0; // в начале игры 0
        countText = GetComponent<TMPro.TextMeshProUGUI>();
        UpdateCounter();
    }

    public void Add()
    {
        counter++;
        UpdateCounter();
    }

    private void UpdateCounter()
    {
        countText.text = counter.ToString();
    }
}
