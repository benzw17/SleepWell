using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{
    ActionBasedController actionBasedController;
    public Hand hand;
    void Start()
    {
        actionBasedController = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        hand.setGrip(actionBasedController.selectAction.action.ReadValue<float>());
        hand.setTrigger(actionBasedController.activateAction.action.ReadValue<float>());
    }
}
