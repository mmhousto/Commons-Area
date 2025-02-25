using UnityEngine;
using TMPro;
public class ContextPrompt : MonoBehaviour
{

    private TextMeshProUGUI prompt;
    public string promptText;
    public GameObject player;

    private void Start()
    {
        prompt = GetComponentInChildren<TextMeshProUGUI>();
        prompt.text = promptText;
        prompt.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(prompt != null)
        {
            prompt.transform.parent.LookAt(player.transform);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            prompt.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            prompt.gameObject.SetActive(false);
        }
    }
}
