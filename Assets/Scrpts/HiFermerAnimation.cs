using Unity.VisualScripting;
using UnityEngine;

public class HiFermerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void OnGazeFermer(bool isGaze)
    {
        animator.SetBool("Hi", isGaze); 
    }
    public void EndHi()
    {
        animator.SetBool("Hi", false);
    }

}
