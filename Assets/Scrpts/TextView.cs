using UnityEngine;

public class TextView : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private Animator textAnimator;

    private void Update()
    {
        transform.LookAt(playerCamera);
    }
    public void OnShow()
    {
        textAnimator.SetBool("isShow", true);
    }
    public void OnHide()
    {
        textAnimator.SetBool("isShow", false);
    }
}
