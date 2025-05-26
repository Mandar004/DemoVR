using UnityEngine;
using UnityEngine.Events;

public class BoxController : MonoBehaviour
{
    public Animator boxAnimator;
    public bool isOpen = false;

    public UnityEvent OnBoxOpened;
    public UnityEvent OnBoxClosed;

    public void ToggleBox()
    {
        isOpen = !isOpen;

        if (boxAnimator != null)
        {
            boxAnimator.SetBool("isOpen", isOpen);
        }

        if (isOpen)
            OnBoxOpened.Invoke();
        else
            OnBoxClosed.Invoke();
    }
}
