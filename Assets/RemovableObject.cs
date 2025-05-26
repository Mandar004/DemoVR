using UnityEngine;

public class RemovableObject : MonoBehaviour
{
    private bool isRemoved = false;

    public void Remove()
    {
        if (isRemoved) return;

        isRemoved = true;
        gameObject.SetActive(false); // or use Destroy(gameObject);
        CompletionManager.Instance.CheckCompletion();
    }
}
