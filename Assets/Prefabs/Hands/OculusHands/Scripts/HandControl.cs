using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandControl : MonoBehaviour
{
    [SerializeField] private ActionBasedController controller;
    [SerializeField] private Hand hand;

    private void Awake()
    {
        controller = GetComponentInParent<ActionBasedController>();
    }


    // Update is called once per frame
    void Update()
    {
        hand.SetGrip(controller.selectAction.action.ReadValue<float>());
        hand.SetTrigger(controller.activateAction.action.ReadValue<float>());
    }
}
