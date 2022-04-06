using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [SerializeField] Text log;

    void Start()
    {
        Application.targetFrameRate = 10;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        log.text = $"horizontal: {horizontal}, vertical: {vertical}";
    }
}
