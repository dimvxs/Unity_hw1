using UnityEngine;
using TMPro; // для работы с текстом

public class SpawnCountersScript : MonoBehaviour
{
    public TextMeshProUGUI pipesText;
    public TextMeshProUGUI foodText;
    public TextMeshProUGUI bananasText;

    private void Start()
    {
       
    }


    void Update()
    {
    pipesText.text = ": " + SpawnerScript.pipesCount;
    foodText.text = ": " + SpawnerScript.ladybugsCount;
    bananasText.text = ": " + SpawnerScript.bananasCount;
    }


}
