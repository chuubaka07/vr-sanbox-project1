using UnityEngine;
using UnityEngine.XR.Hands;

public class FixHandMeshOnFocus : MonoBehaviour
{
    private XRHandMeshController leftMeshController;
    private XRHandMeshController rightMeshController;

    void Start()
    {
        var leftHandObj = GameObject.Find("Left Hand");
        var rightHandObj = GameObject.Find("Right Hand");
        
        if (leftHandObj != null) leftMeshController = leftHandObj.GetComponent<XRHandMeshController>();
        if (rightHandObj != null) rightMeshController = rightHandObj.GetComponent<XRHandMeshController>();
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            if (leftMeshController != null)
            {
                leftMeshController.enabled = false;
                leftMeshController.enabled = true;
            }
            if (rightMeshController != null)
            {
                rightMeshController.enabled = false;
                rightMeshController.enabled = true;
            }
        }
    }
}