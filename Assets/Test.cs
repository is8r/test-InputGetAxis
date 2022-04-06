using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] Text log;
    [SerializeField] Text log2;

    void Start()
    {
        Application.targetFrameRate = 5;
    }

    void Update()
    {
        float horizontalRaw = Input.GetAxisRaw("Horizontal");
        float verticalRaw = Input.GetAxisRaw("Vertical");
        log.text = $"horizontalRaw: {horizontalRaw}, verticalRaw: {verticalRaw}";

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        log2.text = $"horizontal: {horizontal}, vertical: {vertical}";
    }
}
