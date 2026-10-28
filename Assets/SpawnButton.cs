using UnityEngine;
using TMPro;

public class SpawnButton : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private TMP_Text counterText;

    private int count;

    // Called by the XR Simple Interactable's Select Entered event
    public void Spawn()
    {
        GameObject obj = Instantiate(prefab, spawnPoint.position, Random.rotation);
        obj.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 0.6f, 1f, 0.8f, 1f);

        count++;
        if (counterText != null)
            counterText.text = $"Spawned: {count}";
    }
}