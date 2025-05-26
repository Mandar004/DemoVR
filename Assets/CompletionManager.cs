using UnityEngine;

public class CompletionManager : MonoBehaviour
{
    public static CompletionManager Instance;

    public BoxController boxController;
    public GameObject completionPanel;

    private RemovableObject[] removableObjects;

    public void Reload()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        removableObjects = FindObjectsOfType<RemovableObject>();
        completionPanel.SetActive(false);
    }

    public void CheckCompletion()
    {
        foreach (var obj in removableObjects)
        {
            if (obj.gameObject.activeSelf)
                return; // Still some objects left
        }

        if (!boxController.isOpen)
        {
            ShowCompletion();
        }
        else
        {
            Debug.Log("All items removed! Close the box to finish.");
        }
    }

    public void ShowCompletion()
    {
        Debug.Log("Task Complete! Showing completion panel.");
        completionPanel.SetActive(true);
    }
}
